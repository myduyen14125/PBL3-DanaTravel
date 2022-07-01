namespace PBL3
{
    partial class LoadingScr
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.BaNaLabel = new System.Windows.Forms.Label();
            this.pictureInside = new System.Windows.Forms.PictureBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.loadingBox = new System.Windows.Forms.PictureBox();
            this.frameBox = new System.Windows.Forms.PictureBox();
            this.blurBg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurBg)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BaNaLabel
            // 
            this.BaNaLabel.AutoSize = true;
            this.BaNaLabel.BackColor = System.Drawing.Color.White;
            this.BaNaLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaNaLabel.Location = new System.Drawing.Point(298, 436);
            this.BaNaLabel.Name = "BaNaLabel";
            this.BaNaLabel.Size = new System.Drawing.Size(148, 32);
            this.BaNaLabel.TabIndex = 4;
            this.BaNaLabel.Text = "BA NA HILLS";
            this.BaNaLabel.Visible = false;
            // 
            // pictureInside
            // 
            this.pictureInside.Image = global::GUI.Properties.Resources.Ba_Na_Hills;
            this.pictureInside.Location = new System.Drawing.Point(103, 72);
            this.pictureInside.Name = "pictureInside";
            this.pictureInside.Size = new System.Drawing.Size(400, 361);
            this.pictureInside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureInside.TabIndex = 3;
            this.pictureInside.TabStop = false;
            this.pictureInside.Visible = false;
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.Image = global::GUI.Properties.Resources.Logo;
            this.logoBox.Location = new System.Drawing.Point(366, 115);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(314, 233);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // loadingBox
            // 
            this.loadingBox.BackColor = System.Drawing.Color.Transparent;
            this.loadingBox.Image = global::GUI.Properties.Resources.loading_unscreen;
            this.loadingBox.Location = new System.Drawing.Point(401, 279);
            this.loadingBox.Name = "loadingBox";
            this.loadingBox.Size = new System.Drawing.Size(250, 250);
            this.loadingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingBox.TabIndex = 1;
            this.loadingBox.TabStop = false;
            // 
            // frameBox
            // 
            this.frameBox.BackColor = System.Drawing.Color.White;
            this.frameBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.frameBox.Location = new System.Drawing.Point(88, 50);
            this.frameBox.Name = "frameBox";
            this.frameBox.Size = new System.Drawing.Size(432, 427);
            this.frameBox.TabIndex = 2;
            this.frameBox.TabStop = false;
            this.frameBox.Visible = false;
            // 
            // blurBg
            // 
            this.blurBg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blurBg.Image = global::GUI.Properties.Resources.exploreQuote;
            this.blurBg.Location = new System.Drawing.Point(88, 477);
            this.blurBg.Name = "blurBg";
            this.blurBg.Size = new System.Drawing.Size(432, 62);
            this.blurBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blurBg.TabIndex = 7;
            this.blurBg.TabStop = false;
            this.blurBg.Visible = false;
            this.blurBg.Click += new System.EventHandler(this.blurBg_Click);
            // 
            // LoadingScr
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1032, 565);
            this.Controls.Add(this.blurBg);
            this.Controls.Add(this.pictureInside);
            this.Controls.Add(this.BaNaLabel);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.loadingBox);
            this.Controls.Add(this.frameBox);
            this.Name = "LoadingScr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanaTravel";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.PictureBox loadingBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox frameBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureInside;
        private System.Windows.Forms.Label BaNaLabel;
        private System.Windows.Forms.PictureBox blurBg;
    }
}

