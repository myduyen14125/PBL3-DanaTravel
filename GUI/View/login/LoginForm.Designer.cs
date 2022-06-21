namespace PBL3
{
    partial class LoginForm
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
            System.Windows.Forms.LinkLabel signupLink;
            this.lbUsername = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.lbPasswd = new System.Windows.Forms.Label();
            this.passwdInput = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.forgotPassLink = new System.Windows.Forms.LinkLabel();
            this.bgPicBox = new System.Windows.Forms.PictureBox();
            signupLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bgPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // signupLink
            // 
            signupLink.AutoSize = true;
            signupLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            signupLink.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            signupLink.LinkColor = System.Drawing.Color.Black;
            signupLink.Location = new System.Drawing.Point(867, 386);
            signupLink.Name = "signupLink";
            signupLink.Size = new System.Drawing.Size(68, 25);
            signupLink.TabIndex = 9;
            signupLink.TabStop = true;
            signupLink.Text = "Signup";
            signupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLink_LinkClicked);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(617, 198);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(99, 28);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username";
            // 
            // usernameInput
            // 
            this.usernameInput.AcceptsTab = true;
            this.usernameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.usernameInput.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.ForeColor = System.Drawing.Color.White;
            this.usernameInput.Location = new System.Drawing.Point(621, 229);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameInput.Size = new System.Drawing.Size(314, 38);
            this.usernameInput.TabIndex = 2;
            // 
            // lbPasswd
            // 
            this.lbPasswd.AutoSize = true;
            this.lbPasswd.BackColor = System.Drawing.Color.Transparent;
            this.lbPasswd.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswd.Location = new System.Drawing.Point(617, 291);
            this.lbPasswd.Name = "lbPasswd";
            this.lbPasswd.Size = new System.Drawing.Size(94, 28);
            this.lbPasswd.TabIndex = 3;
            this.lbPasswd.Text = "Password";
            // 
            // passwdInput
            // 
            this.passwdInput.AcceptsTab = true;
            this.passwdInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwdInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.passwdInput.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdInput.ForeColor = System.Drawing.Color.White;
            this.passwdInput.Location = new System.Drawing.Point(621, 322);
            this.passwdInput.Name = "passwdInput";
            this.passwdInput.PasswordChar = '*';
            this.passwdInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwdInput.Size = new System.Drawing.Size(314, 38);
            this.passwdInput.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(731, 459);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(131, 62);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.lbTitle.Location = new System.Drawing.Point(541, 88);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(472, 42);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Welcome to DanaTravel!";
            // 
            // forgotPassLink
            // 
            this.forgotPassLink.AutoSize = true;
            this.forgotPassLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.forgotPassLink.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassLink.LinkColor = System.Drawing.Color.Black;
            this.forgotPassLink.Location = new System.Drawing.Point(617, 386);
            this.forgotPassLink.Name = "forgotPassLink";
            this.forgotPassLink.Size = new System.Drawing.Size(147, 25);
            this.forgotPassLink.TabIndex = 8;
            this.forgotPassLink.TabStop = true;
            this.forgotPassLink.Text = "Forgot pasword?";
            this.forgotPassLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPassLink_LinkClicked);
            // 
            // bgPicBox
            // 
            this.bgPicBox.Image = global::GUI.Properties.Resources.bgForgetPass;
            this.bgPicBox.Location = new System.Drawing.Point(-170, -2);
            this.bgPicBox.Name = "bgPicBox";
            this.bgPicBox.Size = new System.Drawing.Size(845, 570);
            this.bgPicBox.TabIndex = 0;
            this.bgPicBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1032, 565);
            this.Controls.Add(signupLink);
            this.Controls.Add(this.forgotPassLink);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.lbPasswd);
            this.Controls.Add(this.passwdInput);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.bgPicBox);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanaTravel";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bgPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bgPicBox;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label lbPasswd;
        private System.Windows.Forms.TextBox passwdInput;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.LinkLabel forgotPassLink;
    }
}