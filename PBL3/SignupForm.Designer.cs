namespace PBL3
{
    partial class SignupForm
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
            System.Windows.Forms.LinkLabel loginLink;
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.passInput = new System.Windows.Forms.TextBox();
            this.signupBtn = new System.Windows.Forms.Button();
            this.lnAsk = new System.Windows.Forms.Label();
            this.lbConfirmPass = new System.Windows.Forms.Label();
            this.confirmPassInput = new System.Windows.Forms.TextBox();
            loginLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // loginLink
            // 
            loginLink.AutoSize = true;
            loginLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            loginLink.Cursor = System.Windows.Forms.Cursors.Hand;
            loginLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            loginLink.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loginLink.LinkColor = System.Drawing.Color.White;
            loginLink.Location = new System.Drawing.Point(635, 418);
            loginLink.Name = "loginLink";
            loginLink.Size = new System.Drawing.Size(59, 25);
            loginLink.TabIndex = 12;
            loginLink.TabStop = true;
            loginLink.Text = "Login";
            loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(409, 133);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(252, 38);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "CREATE ACCOUNT";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(375, 188);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(60, 28);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Email";
            // 
            // usernameInput
            // 
            this.usernameInput.AcceptsTab = true;
            this.usernameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameInput.BackColor = System.Drawing.Color.White;
            this.usernameInput.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.usernameInput.Location = new System.Drawing.Point(380, 219);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameInput.Size = new System.Drawing.Size(314, 38);
            this.usernameInput.TabIndex = 8;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.White;
            this.lbPass.Location = new System.Drawing.Point(375, 260);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(98, 28);
            this.lbPass.TabIndex = 9;
            this.lbPass.Text = "Password";
            // 
            // passInput
            // 
            this.passInput.AcceptsTab = true;
            this.passInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passInput.BackColor = System.Drawing.Color.White;
            this.passInput.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.passInput.Location = new System.Drawing.Point(380, 291);
            this.passInput.Name = "passInput";
            this.passInput.PasswordChar = '*';
            this.passInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passInput.Size = new System.Drawing.Size(314, 38);
            this.passInput.TabIndex = 10;
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.White;
            this.signupBtn.CausesValidation = false;
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.signupBtn.Location = new System.Drawing.Point(469, 463);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(149, 48);
            this.signupBtn.TabIndex = 11;
            this.signupBtn.TabStop = false;
            this.signupBtn.Text = "Signup";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // lnAsk
            // 
            this.lnAsk.AutoSize = true;
            this.lnAsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.lnAsk.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnAsk.ForeColor = System.Drawing.Color.White;
            this.lnAsk.Location = new System.Drawing.Point(375, 418);
            this.lnAsk.Name = "lnAsk";
            this.lnAsk.Size = new System.Drawing.Size(137, 25);
            this.lnAsk.TabIndex = 13;
            this.lnAsk.Text = "Have account?";
            // 
            // lbConfirmPass
            // 
            this.lbConfirmPass.AutoSize = true;
            this.lbConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.lbConfirmPass.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbConfirmPass.ForeColor = System.Drawing.Color.White;
            this.lbConfirmPass.Location = new System.Drawing.Point(375, 332);
            this.lbConfirmPass.Name = "lbConfirmPass";
            this.lbConfirmPass.Size = new System.Drawing.Size(177, 28);
            this.lbConfirmPass.TabIndex = 14;
            this.lbConfirmPass.Text = "Confirm Password";
            // 
            // confirmPassInput
            // 
            this.confirmPassInput.AcceptsTab = true;
            this.confirmPassInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPassInput.BackColor = System.Drawing.Color.White;
            this.confirmPassInput.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.confirmPassInput.Location = new System.Drawing.Point(380, 363);
            this.confirmPassInput.Name = "confirmPassInput";
            this.confirmPassInput.PasswordChar = '*';
            this.confirmPassInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confirmPassInput.Size = new System.Drawing.Size(314, 38);
            this.confirmPassInput.TabIndex = 15;
            // 
            // SignupForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.BackgroundImage = global::PBL3.Properties.Resources.BgCreateAcc;
            this.ClientSize = new System.Drawing.Size(1032, 565);
            this.Controls.Add(this.confirmPassInput);
            this.Controls.Add(this.lbConfirmPass);
            this.Controls.Add(this.lnAsk);
            this.Controls.Add(loginLink);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.lbTitle);
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanaTravel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Label lnAsk;
        private System.Windows.Forms.Label lbConfirmPass;
        private System.Windows.Forms.TextBox confirmPassInput;
    }
}