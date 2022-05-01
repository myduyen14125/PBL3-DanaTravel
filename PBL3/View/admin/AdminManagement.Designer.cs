namespace PBL3.View.admin
{
    partial class AdminManagement
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.name = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.hotelManagement1 = new PBL3.View.tour.HotelManagement();
            this.transportManagement1 = new PBL3.View.tour.TransportManagement();
            this.tourManagement1 = new PBL3.View.TourManagement();
            this.employeeManagement1 = new PBL3.EmployeeManagement();
            this.customer1 = new PBL3.View.admin.CustomerManagement();
            this.btnTour = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.navbar = new System.Windows.Forms.Panel();
            this.btnSite = new System.Windows.Forms.Button();
            this.btnHotel = new System.Windows.Forms.Button();
            this.btnTransport = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siteManagement1 = new PBL3.View.tour.SiteManagement();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.panelContent.SuspendLayout();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(56, 178);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(115, 28);
            this.name.TabIndex = 27;
            this.name.Text = "Admin Yuu";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.siteManagement1);
            this.panelContent.Controls.Add(this.hotelManagement1);
            this.panelContent.Controls.Add(this.transportManagement1);
            this.panelContent.Controls.Add(this.tourManagement1);
            this.panelContent.Controls.Add(this.employeeManagement1);
            this.panelContent.Controls.Add(this.customer1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(199, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(867, 567);
            this.panelContent.TabIndex = 30;
            // 
            // hotelManagement1
            // 
            this.hotelManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotelManagement1.Location = new System.Drawing.Point(0, 0);
            this.hotelManagement1.Name = "hotelManagement1";
            this.hotelManagement1.Size = new System.Drawing.Size(867, 567);
            this.hotelManagement1.TabIndex = 4;
            // 
            // transportManagement1
            // 
            this.transportManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transportManagement1.Location = new System.Drawing.Point(0, 0);
            this.transportManagement1.Name = "transportManagement1";
            this.transportManagement1.Size = new System.Drawing.Size(867, 567);
            this.transportManagement1.TabIndex = 3;
            // 
            // tourManagement1
            // 
            this.tourManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourManagement1.Location = new System.Drawing.Point(0, 0);
            this.tourManagement1.Name = "tourManagement1";
            this.tourManagement1.Size = new System.Drawing.Size(867, 567);
            this.tourManagement1.TabIndex = 2;
            // 
            // employeeManagement1
            // 
            this.employeeManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeManagement1.Location = new System.Drawing.Point(0, 0);
            this.employeeManagement1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeeManagement1.Name = "employeeManagement1";
            this.employeeManagement1.Size = new System.Drawing.Size(867, 567);
            this.employeeManagement1.TabIndex = 0;
            // 
            // customer1
            // 
            this.customer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.customer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer1.Location = new System.Drawing.Point(0, 0);
            this.customer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer1.Name = "customer1";
            this.customer1.Size = new System.Drawing.Size(867, 567);
            this.customer1.TabIndex = 1;
            // 
            // btnTour
            // 
            this.btnTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnTour.CausesValidation = false;
            this.btnTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTour.FlatAppearance.BorderSize = 0;
            this.btnTour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTour.ForeColor = System.Drawing.Color.White;
            this.btnTour.Location = new System.Drawing.Point(0, 340);
            this.btnTour.Name = "btnTour";
            this.btnTour.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTour.Size = new System.Drawing.Size(199, 48);
            this.btnTour.TabIndex = 18;
            this.btnTour.TabStop = false;
            this.btnTour.Text = "Tour";
            this.btnTour.UseVisualStyleBackColor = false;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click_1);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnEmployee.CausesValidation = false;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(0, 242);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(199, 48);
            this.btnEmployee.TabIndex = 17;
            this.btnEmployee.TabStop = false;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnStatistic.CausesValidation = false;
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.btnStatistic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.Location = new System.Drawing.Point(0, 389);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStatistic.Size = new System.Drawing.Size(199, 48);
            this.btnStatistic.TabIndex = 26;
            this.btnStatistic.TabStop = false;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnCustomer.CausesValidation = false;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(0, 291);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(199, 48);
            this.btnCustomer.TabIndex = 27;
            this.btnCustomer.TabStop = false;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.navbar.Controls.Add(this.btnSite);
            this.navbar.Controls.Add(this.btnHotel);
            this.navbar.Controls.Add(this.btnTransport);
            this.navbar.Controls.Add(this.pictureBox5);
            this.navbar.Controls.Add(this.pictureBox4);
            this.navbar.Controls.Add(this.pictureBox3);
            this.navbar.Controls.Add(this.pictureBox2);
            this.navbar.Controls.Add(this.pictureBox1);
            this.navbar.Controls.Add(this.name);
            this.navbar.Controls.Add(this.btnCustomer);
            this.navbar.Controls.Add(this.btnStatistic);
            this.navbar.Controls.Add(this.btnEmployee);
            this.navbar.Controls.Add(this.btnTour);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(199, 567);
            this.navbar.TabIndex = 28;
            // 
            // btnSite
            // 
            this.btnSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnSite.CausesValidation = false;
            this.btnSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSite.FlatAppearance.BorderSize = 0;
            this.btnSite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSite.ForeColor = System.Drawing.Color.White;
            this.btnSite.Location = new System.Drawing.Point(0, 516);
            this.btnSite.Name = "btnSite";
            this.btnSite.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSite.Size = new System.Drawing.Size(199, 48);
            this.btnSite.TabIndex = 30;
            this.btnSite.TabStop = false;
            this.btnSite.Text = "Site";
            this.btnSite.UseVisualStyleBackColor = false;
            this.btnSite.Click += new System.EventHandler(this.btnSite_Click);
            // 
            // btnHotel
            // 
            this.btnHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnHotel.CausesValidation = false;
            this.btnHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotel.FlatAppearance.BorderSize = 0;
            this.btnHotel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotel.ForeColor = System.Drawing.Color.White;
            this.btnHotel.Location = new System.Drawing.Point(0, 473);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHotel.Size = new System.Drawing.Size(199, 48);
            this.btnHotel.TabIndex = 29;
            this.btnHotel.TabStop = false;
            this.btnHotel.Text = "Hotel";
            this.btnHotel.UseVisualStyleBackColor = false;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // btnTransport
            // 
            this.btnTransport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnTransport.CausesValidation = false;
            this.btnTransport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransport.FlatAppearance.BorderSize = 0;
            this.btnTransport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransport.ForeColor = System.Drawing.Color.White;
            this.btnTransport.Location = new System.Drawing.Point(0, 431);
            this.btnTransport.Name = "btnTransport";
            this.btnTransport.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTransport.Size = new System.Drawing.Size(199, 48);
            this.btnTransport.TabIndex = 28;
            this.btnTransport.TabStop = false;
            this.btnTransport.Text = "Transport";
            this.btnTransport.UseVisualStyleBackColor = false;
            this.btnTransport.Click += new System.EventHandler(this.btnTransport_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.pictureBox5.Image = global::PBL3.Properties.Resources.Group_1403;
            this.pictureBox5.Location = new System.Drawing.Point(12, 348);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.pictureBox4.Image = global::PBL3.Properties.Resources.Group_1402;
            this.pictureBox4.Location = new System.Drawing.Point(12, 396);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.pictureBox3.Image = global::PBL3.Properties.Resources.Group_1401;
            this.pictureBox3.Location = new System.Drawing.Point(12, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.pictureBox2.Image = global::PBL3.Properties.Resources.Group_1400;
            this.pictureBox2.Location = new System.Drawing.Point(12, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBL3.Properties.Resources.Group_1404;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // siteManagement1
            // 
            this.siteManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siteManagement1.Location = new System.Drawing.Point(0, 0);
            this.siteManagement1.Name = "siteManagement1";
            this.siteManagement1.Size = new System.Drawing.Size(867, 567);
            this.siteManagement1.TabIndex = 5;
            // 
            // AdminManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1066, 567);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.navbar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManagement";
            this.Load += new System.EventHandler(this.AdminManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel panelContent;
        private EmployeeManagement employeeManagement1;
        private CustomerManagement customer1;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private TourManagement tourManagement1;
        private System.Windows.Forms.Button btnTransport;
        private tour.TransportManagement transportManagement1;
        private System.Windows.Forms.Button btnHotel;
        private tour.HotelManagement hotelManagement1;
        private System.Windows.Forms.Button btnSite;
        private tour.SiteManagement siteManagement1;
    }
}