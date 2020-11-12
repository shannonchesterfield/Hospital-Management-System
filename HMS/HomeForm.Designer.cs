namespace HMS
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.AboutBtn = new FontAwesome.Sharp.IconButton();
            this.MinimizeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.MaximizeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.CloseBtn = new FontAwesome.Sharp.IconPictureBox();
            this.CurrentChildFormLabel = new System.Windows.Forms.Label();
            this.CurrentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomePageButton = new System.Windows.Forms.PictureBox();
            this.PatRegistrationButton = new FontAwesome.Sharp.IconButton();
            this.PatInfoButton = new FontAwesome.Sharp.IconButton();
            this.StaffInfoButton = new FontAwesome.Sharp.IconButton();
            this.AddStaffButton = new FontAwesome.Sharp.IconButton();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.TimePanel = new System.Windows.Forms.Panel();
            this.DatePanel = new System.Windows.Forms.Panel();
            this.DayLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.TitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentChildFormIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePageButton)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.TimePanel.SuspendLayout();
            this.DatePanel.SuspendLayout();
            this.DesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.TitleBarPanel.Controls.Add(this.AboutBtn);
            this.TitleBarPanel.Controls.Add(this.MinimizeBtn);
            this.TitleBarPanel.Controls.Add(this.MaximizeBtn);
            this.TitleBarPanel.Controls.Add(this.CloseBtn);
            this.TitleBarPanel.Controls.Add(this.CurrentChildFormLabel);
            this.TitleBarPanel.Controls.Add(this.CurrentChildFormIcon);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(220, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(837, 73);
            this.TitleBarPanel.TabIndex = 1;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            // 
            // AboutBtn
            // 
            this.AboutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AboutBtn.ForeColor = System.Drawing.Color.White;
            this.AboutBtn.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.AboutBtn.IconColor = System.Drawing.Color.White;
            this.AboutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AboutBtn.IconSize = 48;
            this.AboutBtn.Location = new System.Drawing.Point(540, 13);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Rotation = 0D;
            this.AboutBtn.Size = new System.Drawing.Size(182, 51);
            this.AboutBtn.TabIndex = 5;
            this.AboutBtn.Text = "About";
            this.AboutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AboutBtn.UseVisualStyleBackColor = false;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.MinimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeBtn.IconColor = System.Drawing.Color.White;
            this.MinimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeBtn.IconSize = 25;
            this.MinimizeBtn.Location = new System.Drawing.Point(754, 3);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(27, 25);
            this.MinimizeBtn.TabIndex = 4;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.MaximizeBtn.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.MaximizeBtn.IconColor = System.Drawing.Color.White;
            this.MaximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeBtn.IconSize = 25;
            this.MaximizeBtn.Location = new System.Drawing.Point(782, 3);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(27, 25);
            this.MaximizeBtn.TabIndex = 3;
            this.MaximizeBtn.TabStop = false;
            this.MaximizeBtn.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseBtn.IconColor = System.Drawing.Color.White;
            this.CloseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseBtn.IconSize = 25;
            this.CloseBtn.Location = new System.Drawing.Point(807, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(27, 25);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // CurrentChildFormLabel
            // 
            this.CurrentChildFormLabel.AutoSize = true;
            this.CurrentChildFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentChildFormLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentChildFormLabel.Location = new System.Drawing.Point(73, 27);
            this.CurrentChildFormLabel.Name = "CurrentChildFormLabel";
            this.CurrentChildFormLabel.Size = new System.Drawing.Size(71, 26);
            this.CurrentChildFormLabel.TabIndex = 1;
            this.CurrentChildFormLabel.Text = "Home";
            // 
            // CurrentChildFormIcon
            // 
            this.CurrentChildFormIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.CurrentChildFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.CurrentChildFormIcon.IconColor = System.Drawing.Color.White;
            this.CurrentChildFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CurrentChildFormIcon.IconSize = 50;
            this.CurrentChildFormIcon.Location = new System.Drawing.Point(20, 13);
            this.CurrentChildFormIcon.Name = "CurrentChildFormIcon";
            this.CurrentChildFormIcon.Size = new System.Drawing.Size(50, 57);
            this.CurrentChildFormIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CurrentChildFormIcon.TabIndex = 0;
            this.CurrentChildFormIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HomePageButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panel1.Size = new System.Drawing.Size(220, 127);
            this.panel1.TabIndex = 0;
            // 
            // HomePageButton
            // 
            this.HomePageButton.Image = global::HMS.Properties.Resources.SCLogo;
            this.HomePageButton.Location = new System.Drawing.Point(47, 13);
            this.HomePageButton.Name = "HomePageButton";
            this.HomePageButton.Size = new System.Drawing.Size(109, 91);
            this.HomePageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomePageButton.TabIndex = 0;
            this.HomePageButton.TabStop = false;
            this.HomePageButton.Click += new System.EventHandler(this.HomePageButton_Click);
            // 
            // PatRegistrationButton
            // 
            this.PatRegistrationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PatRegistrationButton.FlatAppearance.BorderSize = 0;
            this.PatRegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatRegistrationButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PatRegistrationButton.ForeColor = System.Drawing.Color.White;
            this.PatRegistrationButton.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.PatRegistrationButton.IconColor = System.Drawing.Color.White;
            this.PatRegistrationButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PatRegistrationButton.IconSize = 48;
            this.PatRegistrationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatRegistrationButton.Location = new System.Drawing.Point(0, 127);
            this.PatRegistrationButton.Name = "PatRegistrationButton";
            this.PatRegistrationButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.PatRegistrationButton.Rotation = 0D;
            this.PatRegistrationButton.Size = new System.Drawing.Size(220, 60);
            this.PatRegistrationButton.TabIndex = 1;
            this.PatRegistrationButton.Text = "Patient Registration";
            this.PatRegistrationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatRegistrationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PatRegistrationButton.UseVisualStyleBackColor = true;
            this.PatRegistrationButton.Click += new System.EventHandler(this.PatRegistration_Click);
            // 
            // PatInfoButton
            // 
            this.PatInfoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PatInfoButton.FlatAppearance.BorderSize = 0;
            this.PatInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatInfoButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PatInfoButton.ForeColor = System.Drawing.Color.White;
            this.PatInfoButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.PatInfoButton.IconColor = System.Drawing.Color.White;
            this.PatInfoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PatInfoButton.IconSize = 48;
            this.PatInfoButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.PatInfoButton.Location = new System.Drawing.Point(0, 187);
            this.PatInfoButton.Name = "PatInfoButton";
            this.PatInfoButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.PatInfoButton.Rotation = 0D;
            this.PatInfoButton.Size = new System.Drawing.Size(220, 60);
            this.PatInfoButton.TabIndex = 2;
            this.PatInfoButton.Text = "Patient Information";
            this.PatInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatInfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PatInfoButton.UseVisualStyleBackColor = true;
            this.PatInfoButton.Click += new System.EventHandler(this.PatInfo_Click);
            // 
            // StaffInfoButton
            // 
            this.StaffInfoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StaffInfoButton.FlatAppearance.BorderSize = 0;
            this.StaffInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffInfoButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.StaffInfoButton.ForeColor = System.Drawing.Color.White;
            this.StaffInfoButton.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.StaffInfoButton.IconColor = System.Drawing.Color.White;
            this.StaffInfoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StaffInfoButton.IconSize = 48;
            this.StaffInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffInfoButton.Location = new System.Drawing.Point(0, 247);
            this.StaffInfoButton.Name = "StaffInfoButton";
            this.StaffInfoButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.StaffInfoButton.Rotation = 0D;
            this.StaffInfoButton.Size = new System.Drawing.Size(220, 60);
            this.StaffInfoButton.TabIndex = 4;
            this.StaffInfoButton.Text = "Staff Information";
            this.StaffInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffInfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StaffInfoButton.UseVisualStyleBackColor = true;
            this.StaffInfoButton.Click += new System.EventHandler(this.StaffInfo_Click);
            // 
            // AddStaffButton
            // 
            this.AddStaffButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddStaffButton.FlatAppearance.BorderSize = 0;
            this.AddStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStaffButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddStaffButton.ForeColor = System.Drawing.Color.White;
            this.AddStaffButton.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.AddStaffButton.IconColor = System.Drawing.Color.White;
            this.AddStaffButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddStaffButton.IconSize = 48;
            this.AddStaffButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStaffButton.Location = new System.Drawing.Point(0, 307);
            this.AddStaffButton.Name = "AddStaffButton";
            this.AddStaffButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AddStaffButton.Rotation = 0D;
            this.AddStaffButton.Size = new System.Drawing.Size(220, 60);
            this.AddStaffButton.TabIndex = 5;
            this.AddStaffButton.Text = "Add Staff";
            this.AddStaffButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStaffButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddStaffButton.UseVisualStyleBackColor = true;
            this.AddStaffButton.Click += new System.EventHandler(this.AddStaff_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.MenuPanel.Controls.Add(this.TimePanel);
            this.MenuPanel.Controls.Add(this.AddStaffButton);
            this.MenuPanel.Controls.Add(this.StaffInfoButton);
            this.MenuPanel.Controls.Add(this.PatInfoButton);
            this.MenuPanel.Controls.Add(this.PatRegistrationButton);
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(220, 519);
            this.MenuPanel.TabIndex = 0;
            // 
            // TimePanel
            // 
            this.TimePanel.Controls.Add(this.DatePanel);
            this.TimePanel.Controls.Add(this.TimeLabel);
            this.TimePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimePanel.Location = new System.Drawing.Point(0, 388);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.Size = new System.Drawing.Size(220, 131);
            this.TimePanel.TabIndex = 6;
            // 
            // DatePanel
            // 
            this.DatePanel.Controls.Add(this.DayLabel);
            this.DatePanel.Controls.Add(this.DateLabel);
            this.DatePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DatePanel.Location = new System.Drawing.Point(0, 68);
            this.DatePanel.Name = "DatePanel";
            this.DatePanel.Size = new System.Drawing.Size(220, 63);
            this.DatePanel.TabIndex = 1;
            // 
            // DayLabel
            // 
            this.DayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DayLabel.AutoSize = true;
            this.DayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.ForeColor = System.Drawing.Color.White;
            this.DayLabel.Location = new System.Drawing.Point(80, 41);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(46, 17);
            this.DayLabel.TabIndex = 4;
            this.DayLabel.Text = "label3";
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(65, 8);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(46, 17);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "label2";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(5, 16);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(109, 39);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(44)))), ((int)(((byte)(93)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(220, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 10);
            this.panel2.TabIndex = 2;
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Controls.Add(this.pictureBox1);
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(220, 83);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(837, 436);
            this.DesktopPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 519);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentChildFormIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomePageButton)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            this.DatePanel.ResumeLayout(false);
            this.DatePanel.PerformLayout();
            this.DesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox HomePageButton;
        private FontAwesome.Sharp.IconButton PatRegistrationButton;
        private FontAwesome.Sharp.IconButton PatInfoButton;
        private FontAwesome.Sharp.IconButton StaffInfoButton;
        private FontAwesome.Sharp.IconButton AddStaffButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label CurrentChildFormLabel;
        private FontAwesome.Sharp.IconPictureBox CurrentChildFormIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox MinimizeBtn;
        private FontAwesome.Sharp.IconPictureBox MaximizeBtn;
        private FontAwesome.Sharp.IconPictureBox CloseBtn;
        private System.Windows.Forms.Panel TimePanel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel DatePanel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label DateLabel;
        private FontAwesome.Sharp.IconButton AboutBtn;
    }
}