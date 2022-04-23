
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
            this.navbar = new System.Windows.Forms.Panel();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.avtFrame = new System.Windows.Forms.PictureBox();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnTour = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.employeeManagement1 = new PBL3.EmployeeManagement();
            this.customer1 = new PBL3.View.admin.CustomerManagement();
            this.tourManagement1 = new PBL3.View.TourManagement();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avtFrame)).BeginInit();
            this.panelContent.SuspendLayout();
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
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.name.Location = new System.Drawing.Point(40, 180);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(113, 28);
            this.name.TabIndex = 27;
            this.name.Text = "Admin Yuu";
            // 
            // navbar
            // 
            this.navbar.BackgroundImage = global::PBL3.Properties.Resources.bgNavbar;
            this.navbar.Controls.Add(this.btnCustomer);
            this.navbar.Controls.Add(this.avtFrame);
            this.navbar.Controls.Add(this.btnStatistic);
            this.navbar.Controls.Add(this.btnEmployee);
            this.navbar.Controls.Add(this.btnTour);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(199, 567);
            this.navbar.TabIndex = 28;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.CausesValidation = false;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.btnCustomer.Location = new System.Drawing.Point(0, 335);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(189, 48);
            this.btnCustomer.TabIndex = 27;
            this.btnCustomer.TabStop = false;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
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
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistic.CausesValidation = false;
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.btnStatistic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.btnStatistic.Location = new System.Drawing.Point(0, 443);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStatistic.Size = new System.Drawing.Size(189, 48);
            this.btnStatistic.TabIndex = 26;
            this.btnStatistic.TabStop = false;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.UseVisualStyleBackColor = false;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.CausesValidation = false;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.btnEmployee.Location = new System.Drawing.Point(0, 281);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(189, 48);
            this.btnEmployee.TabIndex = 17;
            this.btnEmployee.TabStop = false;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
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
            this.btnTour.Location = new System.Drawing.Point(0, 389);
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
            // panelContent
            // 
            this.panelContent.Controls.Add(this.tourManagement1);
            this.panelContent.Controls.Add(this.employeeManagement1);
            this.panelContent.Controls.Add(this.customer1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(199, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(867, 567);
            this.panelContent.TabIndex = 30;
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
            this.customer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer1.Location = new System.Drawing.Point(0, 0);
            this.customer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer1.Name = "customer1";
            this.customer1.Size = new System.Drawing.Size(867, 567);
            this.customer1.TabIndex = 1;
            // 
            // tourManagement1
            // 
            this.tourManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourManagement1.Location = new System.Drawing.Point(0, 0);
            this.tourManagement1.Name = "tourManagement1";
            this.tourManagement1.Size = new System.Drawing.Size(867, 567);
            this.tourManagement1.TabIndex = 2;
            // 
            // AdminManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1066, 567);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.name);
            this.Controls.Add(this.navbar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManagement";
            this.Load += new System.EventHandler(this.AdminManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avtFrame)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.PictureBox avtFrame;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panelContent;
        private EmployeeManagement employeeManagement1;
        private CustomerManagement customer1;
        private TourManagement tourManagement1;
    }
}