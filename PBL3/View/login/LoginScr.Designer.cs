namespace PBL3
{
    partial class LoginScr
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.quoteBox = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.screwRightPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.quoteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screwRightPic)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(79, 311);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(354, 62);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.FlatAppearance.BorderSize = 0;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(79, 406);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(354, 62);
            this.signupBtn.TabIndex = 3;
            this.signupBtn.Text = "Create account";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // quoteBox
            // 
            this.quoteBox.Image = global::PBL3.Properties.Resources.Quote;
            this.quoteBox.Location = new System.Drawing.Point(744, 64);
            this.quoteBox.Name = "quoteBox";
            this.quoteBox.Size = new System.Drawing.Size(296, 58);
            this.quoteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quoteBox.TabIndex = 4;
            this.quoteBox.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::PBL3.Properties.Resources.Logo;
            this.logo.Location = new System.Drawing.Point(100, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(320, 272);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // screwRightPic
            // 
            this.screwRightPic.Image = global::PBL3.Properties.Resources.LinhUngPagodaScrew;
            this.screwRightPic.Location = new System.Drawing.Point(398, 0);
            this.screwRightPic.Name = "screwRightPic";
            this.screwRightPic.Size = new System.Drawing.Size(642, 575);
            this.screwRightPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screwRightPic.TabIndex = 0;
            this.screwRightPic.TabStop = false;
            // 
            // LoginScr
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 565);
            this.Controls.Add(this.quoteBox);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.screwRightPic);
            this.Name = "LoginScr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanaTravel";
            this.Load += new System.EventHandler(this.LoginScr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quoteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screwRightPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox screwRightPic;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.PictureBox quoteBox;
    }
}