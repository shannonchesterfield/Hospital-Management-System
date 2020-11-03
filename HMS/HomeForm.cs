using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using HMS.Child_Forms;

namespace HMS
{
    public partial class HomeForm : Form
    {
        //Fields for button animation
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form CurrentChildForm;

        //Constructor
        public HomeForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            MenuPanel.Controls.Add(leftBorderBtn);
            //Form config that maximizes or miniminzes the form 
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }
        //Adding a digital clock to the bottom left of the form
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm tt");
            DateLabel.Text = DateTime.Now.ToString("MMM dd yyyy");
            DayLabel.Text = DateTime.Now.ToString("dddd");
        }
        //starting timer for clock so time is accurate
        private void HomeForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        //Struct to hold colors, makes things easier when calling ActivateButton()
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(88,156,72);  
            public static Color color2 = Color.FromArgb(255,197,99);
            public static Color color3 = Color.FromArgb(43,160,181);
            public static Color color4 = Color.FromArgb(255,80,117);
            public static Color color5 = Color.FromArgb(245,128,36);
            
        }
        //Method to highlight button upon clicking
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button highlighting
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(50,26,55);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.Size = new Size(10, 50);
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Title bar icon
                CurrentChildFormIcon.IconChar = currentBtn.IconChar;
                CurrentChildFormIcon.IconColor = color;
                //Title bar text
                CurrentChildFormLabel.Text = currentBtn.Text;

            }
        }
        //Method to disable button highlighting when not active
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(50,26,55);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //This method will open the child form associated with the buttons in the main menu
        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }
            CurrentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            DesktopPanel.Controls.Add(ChildForm);
            DesktopPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        //Below are 5 methods for opening each tab from the main menu
        //When a button is clicked, we activate the button to show the graphics and open the respective child form
        private void PatRegistration_Click(object sender, EventArgs e)
        {
           ActivateButton(sender, RGBColors.color1);
           OpenChildForm(new PatientRegistration());
        }

        private void PatInfo_Click(object sender, EventArgs e)
        {
           ActivateButton(sender, RGBColors.color2);
           OpenChildForm(new PatientInformation());
        }

        private void StaffInfo_Click(object sender, EventArgs e)
        {
           ActivateButton(sender, RGBColors.color4);
           OpenChildForm(new StaffInformation());
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
           ActivateButton(sender, RGBColors.color5);
           OpenChildForm(new AddStaff());
        }
        //When a user clicks the logo in the upper left-hand side, everything will reset after running these commands
        private void HomePageButton_Click(object sender, EventArgs e)
        {
            CurrentChildForm.Close();
            ResetForm();
        }
        //Resetting the form by changing everything back to it's default state
        private void ResetForm()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            CurrentChildFormIcon.IconChar = IconChar.Home;
            CurrentChildFormIcon.IconColor = Color.White;
            CurrentChildFormLabel.Text = "Home";
        }

        //Importing libraries to allow user to move the form around through the title bar, because I don't like the original control box
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        
    }
}
