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
            this.navbar = new System.Windows.Forms.Panel();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.manacontainer = new System.Windows.Forms.Panel();
            this.btnRoleAcc = new System.Windows.Forms.Button();
            this.btnAccountEmployee = new System.Windows.Forms.Button();
            this.btnCustomerAcc = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnBackHomepage = new System.Windows.Forms.Button();
            this.btnTour = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.roleAccount1 = new PBL3.View.RoleAccount();
            this.customerAccount1 = new PBL3.View.CustomerAccount();
            this.accountEmployee1 = new PBL3.View.AccountEmployee();
            this.tourManagement1 = new PBL3.View.TourManagement();
            this.employeeManagement1 = new PBL3.EmployeeManagement();
            this.customer1 = new PBL3.View.admin.CustomerManagement();
            this.statistic1 = new PBL3.View.Statistic();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.panelContent.SuspendLayout();
            this.navbar.SuspendLayout();
            this.manacontainer.SuspendLayout();
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
            this.name.Location = new System.Drawing.Point(56, 171);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(115, 28);
            this.name.TabIndex = 27;
            this.name.Text = "Admin Yuu";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.roleAccount1);
            this.panelContent.Controls.Add(this.customerAccount1);
            this.panelContent.Controls.Add(this.accountEmployee1);
            this.panelContent.Controls.Add(this.tourManagement1);
            this.panelContent.Controls.Add(this.employeeManagement1);
            this.panelContent.Controls.Add(this.customer1);
            this.panelContent.Controls.Add(this.statistic1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(199, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(867, 567);
            this.panelContent.TabIndex = 30;
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.navbar.Controls.Add(this.btnStatistic);
            this.navbar.Controls.Add(this.manacontainer);
            this.navbar.Controls.Add(this.btnAccount);
            this.navbar.Controls.Add(this.btnBackHomepage);
            this.navbar.Controls.Add(this.btnTour);
            this.navbar.Controls.Add(this.pictureBox2);
            this.navbar.Controls.Add(this.pictureBox1);
            this.navbar.Controls.Add(this.name);
            this.navbar.Controls.Add(this.btnCustomer);
            this.navbar.Controls.Add(this.btnEmployee);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.MaximumSize = new System.Drawing.Size(199, 567);
            this.navbar.MinimumSize = new System.Drawing.Size(44, 567);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(199, 567);
            this.navbar.TabIndex = 28;
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
            this.btnStatistic.Image = global::PBL3.Properties.Resources.statistic;
            this.btnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.Location = new System.Drawing.Point(0, 489);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStatistic.Size = new System.Drawing.Size(199, 40);
            this.btnStatistic.TabIndex = 26;
            this.btnStatistic.TabStop = false;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // manacontainer
            // 
            this.manacontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.manacontainer.Controls.Add(this.btnRoleAcc);
            this.manacontainer.Controls.Add(this.btnAccountEmployee);
            this.manacontainer.Controls.Add(this.btnCustomerAcc);
            this.manacontainer.Location = new System.Drawing.Point(0, 389);
            this.manacontainer.Name = "manacontainer";
            this.manacontainer.Size = new System.Drawing.Size(199, 101);
            this.manacontainer.TabIndex = 4;
            // 
            // btnRoleAcc
            // 
            this.btnRoleAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.btnRoleAcc.CausesValidation = false;
            this.btnRoleAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoleAcc.FlatAppearance.BorderSize = 0;
            this.btnRoleAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnRoleAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleAcc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleAcc.ForeColor = System.Drawing.Color.White;
            this.btnRoleAcc.Image = global::PBL3.Properties.Resources.Group_167;
            this.btnRoleAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoleAcc.Location = new System.Drawing.Point(0, 66);
            this.btnRoleAcc.Name = "btnRoleAcc";
            this.btnRoleAcc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRoleAcc.Size = new System.Drawing.Size(199, 33);
            this.btnRoleAcc.TabIndex = 37;
            this.btnRoleAcc.TabStop = false;
            this.btnRoleAcc.Text = "     Role Account";
            this.btnRoleAcc.UseVisualStyleBackColor = false;
            this.btnRoleAcc.Click += new System.EventHandler(this.btnRoleAcc_Click);
            // 
            // btnAccountEmployee
            // 
            this.btnAccountEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.btnAccountEmployee.CausesValidation = false;
            this.btnAccountEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountEmployee.FlatAppearance.BorderSize = 0;
            this.btnAccountEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAccountEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAccountEmployee.Image = global::PBL3.Properties.Resources.Group_167;
            this.btnAccountEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountEmployee.Location = new System.Drawing.Point(-1, 0);
            this.btnAccountEmployee.Name = "btnAccountEmployee";
            this.btnAccountEmployee.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAccountEmployee.Size = new System.Drawing.Size(199, 33);
            this.btnAccountEmployee.TabIndex = 33;
            this.btnAccountEmployee.TabStop = false;
            this.btnAccountEmployee.Text = " Employee Account";
            this.btnAccountEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccountEmployee.UseVisualStyleBackColor = false;
            this.btnAccountEmployee.Click += new System.EventHandler(this.btnAccountEmployee_Click);
            // 
            // btnCustomerAcc
            // 
            this.btnCustomerAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.btnCustomerAcc.CausesValidation = false;
            this.btnCustomerAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerAcc.FlatAppearance.BorderSize = 0;
            this.btnCustomerAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCustomerAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerAcc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerAcc.ForeColor = System.Drawing.Color.White;
            this.btnCustomerAcc.Image = global::PBL3.Properties.Resources.Group_167;
            this.btnCustomerAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerAcc.Location = new System.Drawing.Point(-1, 33);
            this.btnCustomerAcc.Name = "btnCustomerAcc";
            this.btnCustomerAcc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCustomerAcc.Size = new System.Drawing.Size(199, 33);
            this.btnCustomerAcc.TabIndex = 36;
            this.btnCustomerAcc.TabStop = false;
            this.btnCustomerAcc.Text = "Customer Account";
            this.btnCustomerAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerAcc.UseVisualStyleBackColor = false;
            this.btnCustomerAcc.Click += new System.EventHandler(this.btnCustomerAcc_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnAccount.CausesValidation = false;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::PBL3.Properties.Resources.account;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 347);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(199, 40);
            this.btnAccount.TabIndex = 35;
            this.btnAccount.TabStop = false;
            this.btnAccount.Text = "             Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnBackHomepage
            // 
            this.btnBackHomepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.btnBackHomepage.CausesValidation = false;
            this.btnBackHomepage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackHomepage.FlatAppearance.BorderSize = 0;
            this.btnBackHomepage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnBackHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackHomepage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackHomepage.ForeColor = System.Drawing.Color.White;
            this.btnBackHomepage.Image = global::PBL3.Properties.Resources.back;
            this.btnBackHomepage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackHomepage.Location = new System.Drawing.Point(0, 532);
            this.btnBackHomepage.Name = "btnBackHomepage";
            this.btnBackHomepage.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBackHomepage.Size = new System.Drawing.Size(43, 28);
            this.btnBackHomepage.TabIndex = 34;
            this.btnBackHomepage.TabStop = false;
            this.btnBackHomepage.UseVisualStyleBackColor = false;
            this.btnBackHomepage.Click += new System.EventHandler(this.btnBackHomepage_Click);
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
            this.btnTour.Image = global::PBL3.Properties.Resources.tour1;
            this.btnTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTour.Location = new System.Drawing.Point(0, 307);
            this.btnTour.Name = "btnTour";
            this.btnTour.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTour.Size = new System.Drawing.Size(199, 40);
            this.btnTour.TabIndex = 28;
            this.btnTour.TabStop = false;
            this.btnTour.Text = "             Tour";
            this.btnTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTour.UseVisualStyleBackColor = false;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.pictureBox2.Image = global::PBL3.Properties.Resources.Group_1400;
            this.pictureBox2.Location = new System.Drawing.Point(12, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
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
            this.btnCustomer.Image = global::PBL3.Properties.Resources.customer;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 267);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(199, 40);
            this.btnCustomer.TabIndex = 27;
            this.btnCustomer.TabStop = false;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
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
            this.btnEmployee.Image = global::PBL3.Properties.Resources.employee;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 227);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(199, 40);
            this.btnEmployee.TabIndex = 17;
            this.btnEmployee.TabStop = false;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // roleAccount1
            // 
            this.roleAccount1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleAccount1.Location = new System.Drawing.Point(0, 0);
            this.roleAccount1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roleAccount1.Name = "roleAccount1";
            this.roleAccount1.Size = new System.Drawing.Size(867, 567);
            this.roleAccount1.TabIndex = 5;
            // 
            // customerAccount1
            // 
            this.customerAccount1.Location = new System.Drawing.Point(-3, 2);
            this.customerAccount1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerAccount1.Name = "customerAccount1";
            this.customerAccount1.Size = new System.Drawing.Size(867, 567);
            this.customerAccount1.TabIndex = 4;
            // 
            // accountEmployee1
            // 
            this.accountEmployee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.accountEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountEmployee1.Location = new System.Drawing.Point(0, 0);
            this.accountEmployee1.Margin = new System.Windows.Forms.Padding(2);
            this.accountEmployee1.Name = "accountEmployee1";
            this.accountEmployee1.Size = new System.Drawing.Size(867, 567);
            this.accountEmployee1.TabIndex = 3;
            // 
            // tourManagement1
            // 
            this.tourManagement1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.tourManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourManagement1.Location = new System.Drawing.Point(0, 0);
            this.tourManagement1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // statistic1
            // 
            this.statistic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statistic1.Location = new System.Drawing.Point(0, 0);
            this.statistic1.Name = "statistic1";
            this.statistic1.Size = new System.Drawing.Size(867, 567);
            this.statistic1.TabIndex = 6;
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
            this.manacontainer.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTour;
        private TourManagement tourManagement1;
        private System.Windows.Forms.Button btnAccountEmployee;
        private AccountEmployee accountEmployee1;
        private System.Windows.Forms.Button btnBackHomepage;
        private System.Windows.Forms.Panel manacontainer;
        private System.Windows.Forms.Button btnRoleAcc;
        private System.Windows.Forms.Button btnCustomerAcc;
        private System.Windows.Forms.Button btnAccount;
        private CustomerAccount customerAccount1;
        private RoleAccount roleAccount1;
        private Statistic statistic1;
    }
}