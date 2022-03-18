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
            this.passwdInput = new System.Windows.Forms.TextBox();
            this.lnName = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.lnAsk = new System.Windows.Forms.Label();
            loginLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
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
            this.lbUsername.Location = new System.Drawing.Point(380, 266);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(104, 28);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Username";
            // 
            // passwdInput
            // 
            this.passwdInput.AcceptsTab = true;
            this.passwdInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwdInput.BackColor = System.Drawing.Color.White;
            this.passwdInput.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.passwdInput.Location = new System.Drawing.Point(385, 297);
            this.passwdInput.Name = "passwdInput";
            this.passwdInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwdInput.Size = new System.Drawing.Size(314, 38);
            this.passwdInput.TabIndex = 8;
            // 
            // lnName
            // 
            this.lnName.AutoSize = true;
            this.lnName.BackColor = System.Drawing.Color.Transparent;
            this.lnName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnName.ForeColor = System.Drawing.Color.White;
            this.lnName.Location = new System.Drawing.Point(380, 184);
            this.lnName.Name = "lnName";
            this.lnName.Size = new System.Drawing.Size(110, 28);
            this.lnName.TabIndex = 5;
            this.lnName.Text = "Your name";
            // 
            // usernameInput
            // 
            this.usernameInput.AcceptsTab = true;
            this.usernameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameInput.BackColor = System.Drawing.Color.White;
            this.usernameInput.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.usernameInput.Location = new System.Drawing.Point(385, 215);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameInput.Size = new System.Drawing.Size(314, 38);
            this.usernameInput.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(381, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(385, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(314, 38);
            this.textBox1.TabIndex = 10;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.White;
            this.loginBtn.CausesValidation = false;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.loginBtn.Location = new System.Drawing.Point(472, 491);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(149, 48);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.TabStop = false;
            this.loginBtn.Text = "Signup";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginLink
            // 
            loginLink.AutoSize = true;
            loginLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            loginLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            loginLink.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loginLink.LinkColor = System.Drawing.Color.White;
            loginLink.Location = new System.Drawing.Point(643, 435);
            loginLink.Name = "loginLink";
            loginLink.Size = new System.Drawing.Size(59, 25);
            loginLink.TabIndex = 12;
            loginLink.TabStop = true;
            loginLink.Text = "Login";
            loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // lnAsk
            // 
            this.lnAsk.AutoSize = true;
            this.lnAsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.lnAsk.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnAsk.ForeColor = System.Drawing.Color.White;
            this.lnAsk.Location = new System.Drawing.Point(381, 435);
            this.lnAsk.Name = "lnAsk";
            this.lnAsk.Size = new System.Drawing.Size(131, 25);
            this.lnAsk.TabIndex = 13;
            this.lnAsk.Text = "Have account?";
            // 
            // SignupForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.BackgroundImage = global::PBL3.Properties.Resources.BgCreateAcc;
            this.ClientSize = new System.Drawing.Size(1032, 565);
            this.Controls.Add(this.lnAsk);
            this.Controls.Add(loginLink);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.passwdInput);
            this.Controls.Add(this.lnName);
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
        private System.Windows.Forms.TextBox passwdInput;
        private System.Windows.Forms.Label lnName;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label lnAsk;
    }
}