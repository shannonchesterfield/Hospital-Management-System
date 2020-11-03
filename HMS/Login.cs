using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HMS
{
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=0219-BQ2G6S2\SQLEXPRESS;Initial Catalog=hospital_management;Integrated Security=True;Pooling=False");
        int count = 0;
        public Login()
        {
            MessageBox.Show("DISCALIMER: I'm not sure how database projects work when taken from Github. For first time users, leave BOTH buttons un-checked and use the login info given on the form.");
            InitializeComponent();
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (PatientBtn.Checked == true)
            {
                String username = Login_UsernameTxtBox.Text;
                String password = Login_PasswordTxtBox.Text;
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from PatientInfo where username= '" + username + "' and password='" + password + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                if (count == 0)
                {
                    MessageBox.Show("Username and/or password is incorrect");
                }
                else
                {
                    this.Hide();
                    HomeForm temp = new HomeForm();
                    temp.Show();
                }
            }
            else if(StaffBtn.Checked == true)
            {
                String username = Login_UsernameTxtBox.Text;
                String password = Login_PasswordTxtBox.Text;
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from StaffInfo where staffusername= '" + username + "' and staffpassword='" + password + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                if (count == 0)
                {
                    MessageBox.Show("Username and/or password is incorrect");
                }
                else
                {
                    this.Hide();
                    HomeForm temp = new HomeForm();
                    temp.Show();
                }
            }
            else if (PatientBtn.Checked == false && StaffBtn.Checked == false)
            {
                if (Login_UsernameTxtBox.Text == "admin" && Login_PasswordTxtBox.Text == "password")
                {
                    this.Hide();
                    HomeForm temp = new HomeForm();
                    temp.Show();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(connect.State==ConnectionState.Open)
            {
                connect.Close();
            }
            connect.Open();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
