namespace HMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginLogo = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Login_PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.Login_UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.Login_PasswordLabel = new System.Windows.Forms.Label();
            this.Login_UsernameLabel = new System.Windows.Forms.Label();
            this.UserTypeLabel = new System.Windows.Forms.Label();
            this.PatientBtn = new System.Windows.Forms.RadioButton();
            this.StaffBtn = new System.Windows.Forms.RadioButton();
            this.UsernameHelperLabel = new System.Windows.Forms.Label();
            this.PasswordHelperLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PasswordHelperLabel);
            this.panel1.Controls.Add(this.UsernameHelperLabel);
            this.panel1.Controls.Add(this.StaffBtn);
            this.panel1.Controls.Add(this.PatientBtn);
            this.panel1.Controls.Add(this.UserTypeLabel);
            this.panel1.Controls.Add(this.LoginLogo);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.Login_PasswordTxtBox);
            this.panel1.Controls.Add(this.Login_UsernameTxtBox);
            this.panel1.Controls.Add(this.Login_PasswordLabel);
            this.panel1.Controls.Add(this.Login_UsernameLabel);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 307);
            this.panel1.TabIndex = 0;
            // 
            // LoginLogo
            // 
            this.LoginLogo.Image = ((System.Drawing.Image)(resources.GetObject("LoginLogo.Image")));
            this.LoginLogo.Location = new System.Drawing.Point(36, 33);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(194, 243);
            this.LoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginLogo.TabIndex = 8;
            this.LoginLogo.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(270, 245);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 31);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(374, 245);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 31);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_PasswordTxtBox
            // 
            this.Login_PasswordTxtBox.Location = new System.Drawing.Point(437, 187);
            this.Login_PasswordTxtBox.Name = "Login_PasswordTxtBox";
            this.Login_PasswordTxtBox.PasswordChar = '*';
            this.Login_PasswordTxtBox.Size = new System.Drawing.Size(125, 22);
            this.Login_PasswordTxtBox.TabIndex = 5;
            // 
            // Login_UsernameTxtBox
            // 
            this.Login_UsernameTxtBox.Location = new System.Drawing.Point(437, 126);
            this.Login_UsernameTxtBox.Name = "Login_UsernameTxtBox";
            this.Login_UsernameTxtBox.Size = new System.Drawing.Size(125, 22);
            this.Login_UsernameTxtBox.TabIndex = 4;
            // 
            // Login_PasswordLabel
            // 
            this.Login_PasswordLabel.AutoSize = true;
            this.Login_PasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_PasswordLabel.Location = new System.Drawing.Point(264, 177);
            this.Login_PasswordLabel.Name = "Login_PasswordLabel";
            this.Login_PasswordLabel.Size = new System.Drawing.Size(134, 33);
            this.Login_PasswordLabel.TabIndex = 2;
            this.Login_PasswordLabel.Text = "Password";
            // 
            // Login_UsernameLabel
            // 
            this.Login_UsernameLabel.AutoSize = true;
            this.Login_UsernameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_UsernameLabel.Location = new System.Drawing.Point(261, 116);
            this.Login_UsernameLabel.Name = "Login_UsernameLabel";
            this.Login_UsernameLabel.Size = new System.Drawing.Size(142, 33);
            this.Login_UsernameLabel.TabIndex = 1;
            this.Login_UsernameLabel.Text = "Username";
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AutoSize = true;
            this.UserTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeLabel.Location = new System.Drawing.Point(368, 33);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(76, 17);
            this.UserTypeLabel.TabIndex = 1;
            this.UserTypeLabel.Text = "Login As:";
            // 
            // PatientBtn
            // 
            this.PatientBtn.AutoSize = true;
            this.PatientBtn.Location = new System.Drawing.Point(301, 67);
            this.PatientBtn.Name = "PatientBtn";
            this.PatientBtn.Size = new System.Drawing.Size(73, 21);
            this.PatientBtn.TabIndex = 9;
            this.PatientBtn.TabStop = true;
            this.PatientBtn.Text = "Patient";
            this.PatientBtn.UseVisualStyleBackColor = true;
            // 
            // StaffBtn
            // 
            this.StaffBtn.AutoSize = true;
            this.StaffBtn.Location = new System.Drawing.Point(437, 67);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.Size = new System.Drawing.Size(58, 21);
            this.StaffBtn.TabIndex = 10;
            this.StaffBtn.TabStop = true;
            this.StaffBtn.Text = "Staff";
            this.StaffBtn.UseVisualStyleBackColor = true;
            // 
            // UsernameHelperLabel
            // 
            this.UsernameHelperLabel.AutoSize = true;
            this.UsernameHelperLabel.Location = new System.Drawing.Point(270, 157);
            this.UsernameHelperLabel.Name = "UsernameHelperLabel";
            this.UsernameHelperLabel.Size = new System.Drawing.Size(168, 17);
            this.UsernameHelperLabel.TabIndex = 11;
            this.UsernameHelperLabel.Text = "Default Username: admin";
            // 
            // PasswordHelperLabel
            // 
            this.PasswordHelperLabel.AutoSize = true;
            this.PasswordHelperLabel.Location = new System.Drawing.Point(270, 212);
            this.PasswordHelperLabel.Name = "PasswordHelperLabel";
            this.PasswordHelperLabel.Size = new System.Drawing.Size(186, 17);
            this.PasswordHelperLabel.TabIndex = 12;
            this.PasswordHelperLabel.Text = "Default Password: password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 301);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox Login_PasswordTxtBox;
        private System.Windows.Forms.TextBox Login_UsernameTxtBox;
        private System.Windows.Forms.Label Login_PasswordLabel;
        private System.Windows.Forms.Label Login_UsernameLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox LoginLogo;
        private System.Windows.Forms.RadioButton StaffBtn;
        private System.Windows.Forms.RadioButton PatientBtn;
        private System.Windows.Forms.Label UserTypeLabel;
        private System.Windows.Forms.Label PasswordHelperLabel;
        private System.Windows.Forms.Label UsernameHelperLabel;
    }
}

