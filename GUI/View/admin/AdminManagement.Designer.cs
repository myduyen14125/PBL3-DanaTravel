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
            this.components = new System.ComponentModel.Container();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.name = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.navbar = new System.Windows.Forms.Panel();
            this.btnAccountEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnBackHomepage = new System.Windows.Forms.Button();
            this.btnTour = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statistic1 = new PBL3.View.statistics.Statistic();
            this.billManagement1 = new PBL3.View.bill.BillManagement();
            this.ticketManagement1 = new PBL3.View.ticket.TicketManagement();
            this.accountEmployee1 = new PBL3.View.AccountEmployee();
            this.tourManagement1 = new PBL3.View.TourManagement();
            this.employeeManagement1 = new PBL3.EmployeeManagement();
            this.customer1 = new PBL3.View.admin.CustomerManagement();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.panelContent.SuspendLayout();
            this.navbar.SuspendLayout();
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
            this.name.Location = new System.Drawing.Point(38, 183);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(128, 21);
            this.name.TabIndex = 27;
            this.name.Text = "Admin Account";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.statistic1);
            this.panelContent.Controls.Add(this.billManagement1);
            this.panelContent.Controls.Add(this.ticketManagement1);
            this.panelContent.Controls.Add(this.accountEmployee1);
            this.panelContent.Controls.Add(this.tourManagement1);
            this.panelContent.Controls.Add(this.employeeManagement1);
            this.panelContent.Controls.Add(this.customer1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(199, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1120, 709);
            this.panelContent.TabIndex = 30;
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.navbar.Controls.Add(this.name);
            this.navbar.Controls.Add(this.btnAccountEmployee);
            this.navbar.Controls.Add(this.label1);
            this.navbar.Controls.Add(this.label2);
            this.navbar.Controls.Add(this.btnBill);
            this.navbar.Controls.Add(this.btnTicket);
            this.navbar.Controls.Add(this.btnStatistic);
            this.navbar.Controls.Add(this.btnBackHomepage);
            this.navbar.Controls.Add(this.btnTour);
            this.navbar.Controls.Add(this.pictureBox2);
            this.navbar.Controls.Add(this.pictureBox1);
            this.navbar.Controls.Add(this.btnCustomer);
            this.navbar.Controls.Add(this.btnEmployee);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(199, 709);
            this.navbar.TabIndex = 28;
            // 
            // btnAccountEmployee
            // 
            this.btnAccountEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnAccountEmployee.CausesValidation = false;
            this.btnAccountEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountEmployee.FlatAppearance.BorderSize = 0;
            this.btnAccountEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAccountEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAccountEmployee.Image = global::GUI.Properties.Resources.Group_3;
            this.btnAccountEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountEmployee.Location = new System.Drawing.Point(-1, 476);
            this.btnAccountEmployee.Name = "btnAccountEmployee";
            this.btnAccountEmployee.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAccountEmployee.Size = new System.Drawing.Size(199, 40);
            this.btnAccountEmployee.TabIndex = 33;
            this.btnAccountEmployee.TabStop = false;
            this.btnAccountEmployee.Text = "             Account";
            this.btnAccountEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountEmployee.UseVisualStyleBackColor = false;
            this.btnAccountEmployee.Click += new System.EventHandler(this.btnAccountEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Quản trị viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(43, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 42);
            this.label2.TabIndex = 38;
            this.label2.Text = ".";
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnBill.CausesValidation = false;
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::GUI.Properties.Resources.iconticket;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(-1, 436);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBill.Size = new System.Drawing.Size(199, 40);
            this.btnBill.TabIndex = 36;
            this.btnBill.TabStop = false;
            this.btnBill.Text = "             Bill";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnTicket.CausesValidation = false;
            this.btnTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicket.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.Color.White;
            this.btnTicket.Image = global::GUI.Properties.Resources.Group_1306;
            this.btnTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.Location = new System.Drawing.Point(-1, 396);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTicket.Size = new System.Drawing.Size(199, 40);
            this.btnTicket.TabIndex = 18;
            this.btnTicket.TabStop = false;
            this.btnTicket.Text = "             Ticket";
            this.btnTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
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
            this.btnStatistic.Image = global::GUI.Properties.Resources.statistic;
            this.btnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.Location = new System.Drawing.Point(-1, 516);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStatistic.Size = new System.Drawing.Size(199, 40);
            this.btnStatistic.TabIndex = 26;
            this.btnStatistic.TabStop = false;
            this.btnStatistic.Text = "             Statistic";
            this.btnStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
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
            this.btnBackHomepage.Image = global::GUI.Properties.Resources.back;
            this.btnBackHomepage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackHomepage.Location = new System.Drawing.Point(2, 676);
            this.btnBackHomepage.Name = "btnBackHomepage";
            this.btnBackHomepage.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBackHomepage.Size = new System.Drawing.Size(43, 28);
            this.btnBackHomepage.TabIndex = 34;
            this.btnBackHomepage.TabStop = false;
            this.toolTip1.SetToolTip(this.btnBackHomepage, "Back");
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
            this.btnTour.Image = global::GUI.Properties.Resources.tour1;
            this.btnTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTour.Location = new System.Drawing.Point(-1, 356);
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
            this.pictureBox2.Image = global::GUI.Properties.Resources.Group_1400;
            this.pictureBox2.Location = new System.Drawing.Point(12, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Group_1404;
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
            this.btnCustomer.Image = global::GUI.Properties.Resources.customer;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(-1, 316);
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
            this.btnEmployee.Image = global::GUI.Properties.Resources.employee;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(-1, 276);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(199, 40);
            this.btnEmployee.TabIndex = 17;
            this.btnEmployee.TabStop = false;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // statistic1
            // 
            this.statistic1.AutoSize = true;
            this.statistic1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.statistic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statistic1.Location = new System.Drawing.Point(0, 0);
            this.statistic1.Margin = new System.Windows.Forms.Padding(2);
            this.statistic1.Name = "statistic1";
            this.statistic1.Size = new System.Drawing.Size(1120, 709);
            this.statistic1.TabIndex = 8;
            // 
            // billManagement1
            // 
            this.billManagement1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.billManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billManagement1.Location = new System.Drawing.Point(0, 0);
            this.billManagement1.Margin = new System.Windows.Forms.Padding(2);
            this.billManagement1.Name = "billManagement1";
            this.billManagement1.Size = new System.Drawing.Size(1120, 709);
            this.billManagement1.TabIndex = 7;
            // 
            // ticketManagement1
            // 
            this.ticketManagement1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.ticketManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketManagement1.Location = new System.Drawing.Point(0, 0);
            this.ticketManagement1.Margin = new System.Windows.Forms.Padding(2);
            this.ticketManagement1.Name = "ticketManagement1";
            this.ticketManagement1.Size = new System.Drawing.Size(1120, 709);
            this.ticketManagement1.TabIndex = 6;
            // 
            // accountEmployee1
            // 
            this.accountEmployee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.accountEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountEmployee1.Location = new System.Drawing.Point(0, 0);
            this.accountEmployee1.Margin = new System.Windows.Forms.Padding(2);
            this.accountEmployee1.Name = "accountEmployee1";
            this.accountEmployee1.Size = new System.Drawing.Size(1120, 709);
            this.accountEmployee1.TabIndex = 3;
            // 
            // tourManagement1
            // 
            this.tourManagement1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.tourManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourManagement1.Location = new System.Drawing.Point(0, 0);
            this.tourManagement1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tourManagement1.Name = "tourManagement1";
            this.tourManagement1.Size = new System.Drawing.Size(1120, 709);
            this.tourManagement1.TabIndex = 2;
            // 
            // employeeManagement1
            // 
            this.employeeManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeManagement1.Location = new System.Drawing.Point(0, 0);
            this.employeeManagement1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeeManagement1.Name = "employeeManagement1";
            this.employeeManagement1.Size = new System.Drawing.Size(1120, 709);
            this.employeeManagement1.TabIndex = 0;
            // 
            // customer1
            // 
            this.customer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.customer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer1.Location = new System.Drawing.Point(0, 0);
            this.customer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer1.Name = "customer1";
            this.customer1.Size = new System.Drawing.Size(1120, 709);
            this.customer1.TabIndex = 1;
            // 
            // AdminManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1319, 709);
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
            this.panelContent.PerformLayout();
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
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
        private AccountEmployee accountEmployee1;
        private System.Windows.Forms.Button btnBackHomepage;
       
        private System.Windows.Forms.Button btnTicket;
        private ticket.TicketManagement ticketManagement1;
        private bill.BillManagement billManagement1;
        private System.Windows.Forms.Button btnBill;
        private statistics.Statistic statistic1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccountEmployee;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}