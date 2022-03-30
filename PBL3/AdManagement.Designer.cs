namespace PBL3
{
    partial class AdManagement
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
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navbar = new System.Windows.Forms.Panel();
            this.avtFrame = new System.Windows.Forms.PictureBox();
            this.btnHuman = new System.Windows.Forms.Button();
            this.btnTour = new System.Windows.Forms.Button();
            this.tourManagement = new PBL3.TourManagement();
            this.humanResource = new PBL3.HumanResource();
            this.panel1.SuspendLayout();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avtFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.CausesValidation = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.button1.Location = new System.Drawing.Point(1, 369);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(189, 48);
            this.button1.TabIndex = 19;
            this.button1.TabStop = false;
            this.button1.Text = "Statistic";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.name.Location = new System.Drawing.Point(40, 180);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(113, 28);
            this.name.TabIndex = 21;
            this.name.Text = "Admin Yuu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.humanResource);
            this.panel1.Controls.Add(this.tourManagement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(199, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 567);
            this.panel1.TabIndex = 25;
            // 
            // navbar
            // 
            this.navbar.BackgroundImage = global::PBL3.Properties.Resources.bgNavbar;
            this.navbar.Controls.Add(this.avtFrame);
            this.navbar.Controls.Add(this.btnHuman);
            this.navbar.Controls.Add(this.btnTour);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(199, 567);
            this.navbar.TabIndex = 24;
            // 
            // avtFrame
            // 
            this.avtFrame.BackColor = System.Drawing.Color.Transparent;
            this.avtFrame.Image = global::PBL3.Properties.Resources._56986749_694943527575452_6002140096634028032_n;
            this.avtFrame.Location = new System.Drawing.Point(3, 0);
            this.avtFrame.Name = "avtFrame";
            this.avtFrame.Size = new System.Drawing.Size(187, 174);
            this.avtFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avtFrame.TabIndex = 20;
            this.avtFrame.TabStop = false;
            // 
            // btnHuman
            // 
            this.btnHuman.BackColor = System.Drawing.Color.Transparent;
            this.btnHuman.CausesValidation = false;
            this.btnHuman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuman.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHuman.FlatAppearance.BorderSize = 0;
            this.btnHuman.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnHuman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuman.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.btnHuman.Location = new System.Drawing.Point(1, 281);
            this.btnHuman.Name = "btnHuman";
            this.btnHuman.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHuman.Size = new System.Drawing.Size(189, 48);
            this.btnHuman.TabIndex = 17;
            this.btnHuman.TabStop = false;
            this.btnHuman.Text = "Human resources";
            this.btnHuman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuman.UseVisualStyleBackColor = false;
            this.btnHuman.Click += new System.EventHandler(this.btnHuman_Click);
            // 
            // btnTour
            // 
            this.btnTour.BackColor = System.Drawing.Color.Transparent;
            this.btnTour.CausesValidation = false;
            this.btnTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTour.FlatAppearance.BorderSize = 0;
            this.btnTour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.btnTour.Location = new System.Drawing.Point(1, 325);
            this.btnTour.Name = "btnTour";
            this.btnTour.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTour.Size = new System.Drawing.Size(189, 48);
            this.btnTour.TabIndex = 18;
            this.btnTour.TabStop = false;
            this.btnTour.Text = "Tour";
            this.btnTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTour.UseVisualStyleBackColor = false;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // tourManagement
            // 
            this.tourManagement.AutoSize = true;
            this.tourManagement.BackColor = System.Drawing.Color.White;
            this.tourManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourManagement.Location = new System.Drawing.Point(0, 0);
            this.tourManagement.Name = "tourManagement";
            this.tourManagement.Size = new System.Drawing.Size(833, 567);
            this.tourManagement.TabIndex = 1;
            // 
            // humanResource
            // 
            this.humanResource.AutoSize = true;
            this.humanResource.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.humanResource.Location = new System.Drawing.Point(0, -127);
            this.humanResource.Name = "humanResource";
            this.humanResource.Size = new System.Drawing.Size(833, 694);
            this.humanResource.TabIndex = 2;
            // 
            // AdManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.navbar);
            this.Name = "AdManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanaTravel";
            this.Load += new System.EventHandler(this.AdManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avtFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHuman;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox avtFrame;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Panel panel1;
        private TourManagement tourManagement;
        private HumanResource humanResource;
    }
}