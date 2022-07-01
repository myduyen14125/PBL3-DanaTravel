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
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.signupBtn = new System.Windows.Forms.Button();
            this.confirmPassInput = new System.Windows.Forms.TextBox();
            this.OTPbox = new System.Windows.Forms.PictureBox();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.btnGetOTP = new System.Windows.Forms.Button();
            loginLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.OTPbox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLink
            // 
            loginLink.AutoSize = true;
            loginLink.BackColor = System.Drawing.Color.Transparent;
            loginLink.Cursor = System.Windows.Forms.Cursors.Hand;
            loginLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            loginLink.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loginLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            loginLink.Location = new System.Drawing.Point(757, 527);
            loginLink.Name = "loginLink";
            loginLink.Size = new System.Drawing.Size(47, 20);
            loginLink.TabIndex = 12;
            loginLink.TabStop = true;
            loginLink.Text = "Login";
            loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // usernameInput
            // 
            this.usernameInput.AcceptsTab = true;
            this.usernameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameInput.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.usernameInput.Location = new System.Drawing.Point(624, 212);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameInput.Size = new System.Drawing.Size(314, 22);
            this.usernameInput.TabIndex = 8;
            this.usernameInput.Text = "E-mail address";
            this.usernameInput.Click += new System.EventHandler(this.usernameInput_Click);
            // 
            // passInput
            // 
            this.passInput.AcceptsTab = true;
            this.passInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.passInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passInput.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.passInput.Location = new System.Drawing.Point(624, 282);
            this.passInput.Name = "passInput";
            this.passInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passInput.Size = new System.Drawing.Size(314, 22);
            this.passInput.TabIndex = 10;
            this.passInput.Text = "Password";
            this.passInput.Click += new System.EventHandler(this.passInput_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.signupBtn.CausesValidation = false;
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.FlatAppearance.BorderSize = 0;
            this.signupBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(694, 465);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(176, 40);
            this.signupBtn.TabIndex = 11;
            this.signupBtn.TabStop = false;
            this.signupBtn.Text = "Sign up";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // confirmPassInput
            // 
            this.confirmPassInput.AcceptsTab = true;
            this.confirmPassInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPassInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.confirmPassInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPassInput.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.confirmPassInput.Location = new System.Drawing.Point(624, 352);
            this.confirmPassInput.Name = "confirmPassInput";
            this.confirmPassInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confirmPassInput.Size = new System.Drawing.Size(314, 22);
            this.confirmPassInput.TabIndex = 15;
            this.confirmPassInput.Text = "Confirm password";
            this.confirmPassInput.Click += new System.EventHandler(this.confirmPassInput_Click);
            // 
            // OTPbox
            // 
            this.OTPbox.BackColor = System.Drawing.Color.Transparent;
            this.OTPbox.Image = global::GUI.Properties.Resources.roundedInput;
            this.OTPbox.Location = new System.Drawing.Point(611, 412);
            this.OTPbox.Name = "OTPbox";
            this.OTPbox.Size = new System.Drawing.Size(227, 45);
            this.OTPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OTPbox.TabIndex = 16;
            this.OTPbox.TabStop = false;
            // 
            // txtOTP
            // 
            this.txtOTP.AcceptsTab = true;
            this.txtOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.txtOTP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOTP.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtOTP.Location = new System.Drawing.Point(624, 419);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOTP.Size = new System.Drawing.Size(173, 22);
            this.txtOTP.TabIndex = 17;
            this.txtOTP.Text = "Input OTP";
            this.txtOTP.Click += new System.EventHandler(this.txtOTP_Click);
            // 
            // btnGetOTP
            // 
            this.btnGetOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnGetOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetOTP.FlatAppearance.BorderSize = 0;
            this.btnGetOTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGetOTP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetOTP.Location = new System.Drawing.Point(863, 412);
            this.btnGetOTP.Name = "btnGetOTP";
            this.btnGetOTP.Size = new System.Drawing.Size(83, 45);
            this.btnGetOTP.TabIndex = 18;
            this.btnGetOTP.Text = "Get OTP";
            this.btnGetOTP.UseVisualStyleBackColor = false;
            this.btnGetOTP.Click += new System.EventHandler(this.btnGetOTP_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.BackgroundImage = global::GUI.Properties.Resources._18__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 565);
            this.Controls.Add(this.btnGetOTP);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.OTPbox);
            this.Controls.Add(this.confirmPassInput);
            this.Controls.Add(loginLink);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.usernameInput);
            this.DoubleBuffered = true;
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanaTravel";
            ((System.ComponentModel.ISupportInitialize)(this.OTPbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.TextBox confirmPassInput;
        private System.Windows.Forms.PictureBox OTPbox;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button btnGetOTP;
    }
}