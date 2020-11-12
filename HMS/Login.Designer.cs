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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.PasswordHelperLabel = new System.Windows.Forms.Label();
            this.UsernameHelperLabel = new System.Windows.Forms.Label();
            this.StaffBtn = new System.Windows.Forms.RadioButton();
            this.PatientBtn = new System.Windows.Forms.RadioButton();
            this.UserTypeLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Login_PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.Login_UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.Login_PasswordLabel = new System.Windows.Forms.Label();
            this.Login_UsernameLabel = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.LoginPanel.Controls.Add(this.iconPictureBox1);
            this.LoginPanel.Controls.Add(this.PasswordHelperLabel);
            this.LoginPanel.Controls.Add(this.UsernameHelperLabel);
            this.LoginPanel.Controls.Add(this.StaffBtn);
            this.LoginPanel.Controls.Add(this.PatientBtn);
            this.LoginPanel.Controls.Add(this.UserTypeLabel);
            this.LoginPanel.Controls.Add(this.CloseButton);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.Login_PasswordTxtBox);
            this.LoginPanel.Controls.Add(this.Login_UsernameTxtBox);
            this.LoginPanel.Controls.Add(this.Login_PasswordLabel);
            this.LoginPanel.Controls.Add(this.Login_UsernameLabel);
            this.LoginPanel.Location = new System.Drawing.Point(-1, -1);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(455, 587);
            this.LoginPanel.TabIndex = 0;
            // 
            // PasswordHelperLabel
            // 
            this.PasswordHelperLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordHelperLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordHelperLabel.Location = new System.Drawing.Point(47, 363);
            this.PasswordHelperLabel.Name = "PasswordHelperLabel";
            this.PasswordHelperLabel.Size = new System.Drawing.Size(274, 28);
            this.PasswordHelperLabel.TabIndex = 12;
            this.PasswordHelperLabel.Text = "Default Password: password";
            // 
            // UsernameHelperLabel
            // 
            this.UsernameHelperLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameHelperLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameHelperLabel.Location = new System.Drawing.Point(46, 304);
            this.UsernameHelperLabel.Name = "UsernameHelperLabel";
            this.UsernameHelperLabel.Size = new System.Drawing.Size(236, 31);
            this.UsernameHelperLabel.TabIndex = 11;
            this.UsernameHelperLabel.Text = "Default Username: admin";
            // 
            // StaffBtn
            // 
            this.StaffBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StaffBtn.ForeColor = System.Drawing.Color.White;
            this.StaffBtn.Location = new System.Drawing.Point(248, 218);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.Size = new System.Drawing.Size(95, 36);
            this.StaffBtn.TabIndex = 10;
            this.StaffBtn.TabStop = true;
            this.StaffBtn.Text = "Staff";
            this.StaffBtn.UseVisualStyleBackColor = true;
            // 
            // PatientBtn
            // 
            this.PatientBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PatientBtn.ForeColor = System.Drawing.Color.White;
            this.PatientBtn.Location = new System.Drawing.Point(112, 218);
            this.PatientBtn.Name = "PatientBtn";
            this.PatientBtn.Size = new System.Drawing.Size(98, 36);
            this.PatientBtn.TabIndex = 9;
            this.PatientBtn.TabStop = true;
            this.PatientBtn.Text = "Patient";
            this.PatientBtn.UseVisualStyleBackColor = true;
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeLabel.ForeColor = System.Drawing.Color.White;
            this.UserTypeLabel.Location = new System.Drawing.Point(179, 184);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(103, 31);
            this.UserTypeLabel.TabIndex = 1;
            this.UserTypeLabel.Text = "Login As:";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.CloseButton.Location = new System.Drawing.Point(84, 413);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(95, 48);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.LoginButton.Location = new System.Drawing.Point(248, 413);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(95, 48);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_PasswordTxtBox
            // 
            this.Login_PasswordTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_PasswordTxtBox.ForeColor = System.Drawing.Color.Black;
            this.Login_PasswordTxtBox.Location = new System.Drawing.Point(248, 338);
            this.Login_PasswordTxtBox.Name = "Login_PasswordTxtBox";
            this.Login_PasswordTxtBox.PasswordChar = '*';
            this.Login_PasswordTxtBox.Size = new System.Drawing.Size(125, 22);
            this.Login_PasswordTxtBox.TabIndex = 5;
            // 
            // Login_UsernameTxtBox
            // 
            this.Login_UsernameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_UsernameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.Login_UsernameTxtBox.Location = new System.Drawing.Point(248, 277);
            this.Login_UsernameTxtBox.Name = "Login_UsernameTxtBox";
            this.Login_UsernameTxtBox.Size = new System.Drawing.Size(125, 22);
            this.Login_UsernameTxtBox.TabIndex = 4;
            // 
            // Login_PasswordLabel
            // 
            this.Login_PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_PasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.Login_PasswordLabel.Location = new System.Drawing.Point(45, 328);
            this.Login_PasswordLabel.Name = "Login_PasswordLabel";
            this.Login_PasswordLabel.Size = new System.Drawing.Size(188, 33);
            this.Login_PasswordLabel.TabIndex = 2;
            this.Login_PasswordLabel.Text = "Password";
            // 
            // Login_UsernameLabel
            // 
            this.Login_UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_UsernameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.Login_UsernameLabel.Location = new System.Drawing.Point(41, 267);
            this.Login_UsernameLabel.Name = "Login_UsernameLabel";
            this.Login_UsernameLabel.Size = new System.Drawing.Size(192, 33);
            this.Login_UsernameLabel.TabIndex = 1;
            this.Login_UsernameLabel.Text = "Username";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 121;
            this.iconPictureBox1.Location = new System.Drawing.Point(160, 60);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(145, 121);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 13;
            this.iconPictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 586);
            this.ControlBox = false;
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Login_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox Login_PasswordTxtBox;
        private System.Windows.Forms.TextBox Login_UsernameTxtBox;
        private System.Windows.Forms.Label Login_PasswordLabel;
        private System.Windows.Forms.Label Login_UsernameLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.RadioButton StaffBtn;
        private System.Windows.Forms.RadioButton PatientBtn;
        private System.Windows.Forms.Label UserTypeLabel;
        private System.Windows.Forms.Label PasswordHelperLabel;
        private System.Windows.Forms.Label UsernameHelperLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

