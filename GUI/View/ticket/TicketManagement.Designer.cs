namespace PBL3.View.ticket
{
    partial class TicketManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.tabStatus = new System.Windows.Forms.TabControl();
            this.tabStatusWait = new System.Windows.Forms.TabPage();
            this.headerFlowLayout = new Guna.UI2.WinForms.Guna2Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNumberAdults = new System.Windows.Forms.Label();
            this.lbNumberChildrens = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.flowLayoutTabWait = new System.Windows.Forms.FlowLayoutPanel();
            this.tabStatusOK = new System.Windows.Forms.TabPage();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayouthTabOK = new System.Windows.Forms.FlowLayoutPanel();
            this.tabStatusCancel = new System.Windows.Forms.TabPage();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.flowLayoutTabCancel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.tabStatus.SuspendLayout();
            this.tabStatusWait.SuspendLayout();
            this.headerFlowLayout.SuspendLayout();
            this.tabStatusOK.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tabStatusCancel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.label1.Location = new System.Drawing.Point(510, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Management";
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.tabStatusWait);
            this.tabStatus.Controls.Add(this.tabStatusOK);
            this.tabStatus.Controls.Add(this.tabStatusCancel);
            this.tabStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabStatus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabStatus.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabStatus.ItemSize = new System.Drawing.Size(150, 30);
            this.tabStatus.Location = new System.Drawing.Point(96, 160);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.SelectedIndex = 0;
            this.tabStatus.Size = new System.Drawing.Size(1205, 644);
            this.tabStatus.TabIndex = 2;
            this.tabStatus.SelectedIndexChanged += new System.EventHandler(this.tabStatus_SelectedIndexChanged);
            // 
            // tabStatusWait
            // 
            this.tabStatusWait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatusWait.Controls.Add(this.headerFlowLayout);
            this.tabStatusWait.Controls.Add(this.flowLayoutTabWait);
            this.tabStatusWait.Location = new System.Drawing.Point(4, 34);
            this.tabStatusWait.Name = "tabStatusWait";
            this.tabStatusWait.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusWait.Size = new System.Drawing.Size(1197, 606);
            this.tabStatusWait.TabIndex = 0;
            this.tabStatusWait.Text = "Đang chờ xác nhận";
            this.tabStatusWait.UseVisualStyleBackColor = true;
            // 
            // headerFlowLayout
            // 
            this.headerFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerFlowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.headerFlowLayout.BorderColor = System.Drawing.Color.Black;
            this.headerFlowLayout.BorderThickness = 1;
            this.headerFlowLayout.Controls.Add(this.lbDate);
            this.headerFlowLayout.Controls.Add(this.label3);
            this.headerFlowLayout.Controls.Add(this.label2);
            this.headerFlowLayout.Controls.Add(this.lbNumberAdults);
            this.headerFlowLayout.Controls.Add(this.lbNumberChildrens);
            this.headerFlowLayout.Controls.Add(this.lbPhone);
            this.headerFlowLayout.Controls.Add(this.lbEmail);
            this.headerFlowLayout.Controls.Add(this.lbCCCD);
            this.headerFlowLayout.Controls.Add(this.lbName);
            this.headerFlowLayout.ForeColor = System.Drawing.Color.White;
            this.headerFlowLayout.Location = new System.Drawing.Point(12, 2);
            this.headerFlowLayout.Name = "headerFlowLayout";
            this.headerFlowLayout.Size = new System.Drawing.Size(1159, 42);
            this.headerFlowLayout.TabIndex = 1;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDate.Location = new System.Drawing.Point(762, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(43, 19);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(1100, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hủy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(1015, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Duyệt";
            // 
            // lbNumberAdults
            // 
            this.lbNumberAdults.AutoSize = true;
            this.lbNumberAdults.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNumberAdults.Location = new System.Drawing.Point(863, 9);
            this.lbNumberAdults.Name = "lbNumberAdults";
            this.lbNumberAdults.Size = new System.Drawing.Size(55, 19);
            this.lbNumberAdults.TabIndex = 4;
            this.lbNumberAdults.Text = "N/Lớn";
            // 
            // lbNumberChildrens
            // 
            this.lbNumberChildrens.AutoSize = true;
            this.lbNumberChildrens.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNumberChildrens.Location = new System.Drawing.Point(944, 9);
            this.lbNumberChildrens.Name = "lbNumberChildrens";
            this.lbNumberChildrens.Size = new System.Drawing.Size(46, 19);
            this.lbNumberChildrens.TabIndex = 4;
            this.lbNumberChildrens.Text = "T/em";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPhone.Location = new System.Drawing.Point(634, 9);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(55, 19);
            this.lbPhone.TabIndex = 3;
            this.lbPhone.Text = "Phone";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbEmail.Location = new System.Drawing.Point(300, 9);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(54, 19);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email";
            // 
            // lbCCCD
            // 
            this.lbCCCD.AutoSize = true;
            this.lbCCCD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCCCD.Location = new System.Drawing.Point(496, 9);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(57, 19);
            this.lbCCCD.TabIndex = 2;
            this.lbCCCD.Text = "CCCD";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(51, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(78, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Họ và tên";
            // 
            // flowLayoutTabWait
            // 
            this.flowLayoutTabWait.AutoScroll = true;
            this.flowLayoutTabWait.Location = new System.Drawing.Point(12, 50);
            this.flowLayoutTabWait.Name = "flowLayoutTabWait";
            this.flowLayoutTabWait.Size = new System.Drawing.Size(1159, 538);
            this.flowLayoutTabWait.TabIndex = 0;
            // 
            // tabStatusOK
            // 
            this.tabStatusOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatusOK.Controls.Add(this.guna2Panel1);
            this.tabStatusOK.Controls.Add(this.flowLayouthTabOK);
            this.tabStatusOK.Location = new System.Drawing.Point(4, 34);
            this.tabStatusOK.Name = "tabStatusOK";
            this.tabStatusOK.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusOK.Size = new System.Drawing.Size(1197, 606);
            this.tabStatusOK.TabIndex = 1;
            this.tabStatusOK.Text = "Đã xác nhận";
            this.tabStatusOK.UseVisualStyleBackColor = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.label10);
            this.guna2Panel1.Controls.Add(this.label11);
            this.guna2Panel1.Controls.Add(this.label12);
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(13, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1159, 42);
            this.guna2Panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(768, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(1100, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hủy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(1015, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Duyệt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(863, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "N/Lớn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(944, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "T/em";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(638, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(300, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(502, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "CCCD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(51, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Họ và tên";
            // 
            // flowLayouthTabOK
            // 
            this.flowLayouthTabOK.Location = new System.Drawing.Point(12, 49);
            this.flowLayouthTabOK.Name = "flowLayouthTabOK";
            this.flowLayouthTabOK.Size = new System.Drawing.Size(1160, 533);
            this.flowLayouthTabOK.TabIndex = 5;
            // 
            // tabStatusCancel
            // 
            this.tabStatusCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatusCancel.Controls.Add(this.guna2Panel2);
            this.tabStatusCancel.Controls.Add(this.flowLayoutTabCancel);
            this.tabStatusCancel.Location = new System.Drawing.Point(4, 34);
            this.tabStatusCancel.Name = "tabStatusCancel";
            this.tabStatusCancel.Size = new System.Drawing.Size(1197, 606);
            this.tabStatusCancel.TabIndex = 2;
            this.tabStatusCancel.Text = "Đã bị hủy";
            this.tabStatusCancel.UseVisualStyleBackColor = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label13);
            this.guna2Panel2.Controls.Add(this.label14);
            this.guna2Panel2.Controls.Add(this.label15);
            this.guna2Panel2.Controls.Add(this.label16);
            this.guna2Panel2.Controls.Add(this.label17);
            this.guna2Panel2.Controls.Add(this.label18);
            this.guna2Panel2.Controls.Add(this.label19);
            this.guna2Panel2.Controls.Add(this.label20);
            this.guna2Panel2.Controls.Add(this.label21);
            this.guna2Panel2.ForeColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(9, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1159, 42);
            this.guna2Panel2.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(755, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 19);
            this.label13.TabIndex = 7;
            this.label13.Text = "Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(1100, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 19);
            this.label14.TabIndex = 6;
            this.label14.Text = "Hủy";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(1015, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 19);
            this.label15.TabIndex = 5;
            this.label15.Text = "Duyệt";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(863, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 19);
            this.label16.TabIndex = 4;
            this.label16.Text = "N/Lớn";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(944, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 19);
            this.label17.TabIndex = 4;
            this.label17.Text = "T/em";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(628, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 19);
            this.label18.TabIndex = 3;
            this.label18.Text = "Phone";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.Location = new System.Drawing.Point(300, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 19);
            this.label19.TabIndex = 1;
            this.label19.Text = "Email";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label20.Location = new System.Drawing.Point(496, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 19);
            this.label20.TabIndex = 2;
            this.label20.Text = "CCCD";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label21.Location = new System.Drawing.Point(51, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 19);
            this.label21.TabIndex = 0;
            this.label21.Text = "Họ và tên";
            // 
            // flowLayoutTabCancel
            // 
            this.flowLayoutTabCancel.Location = new System.Drawing.Point(3, 51);
            this.flowLayoutTabCancel.Name = "flowLayoutTabCancel";
            this.flowLayoutTabCancel.Size = new System.Drawing.Size(1165, 537);
            this.flowLayoutTabCancel.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(965, 135);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 27);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1203, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 42);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.Control;
            this.btnReload.BorderColor = System.Drawing.Color.Transparent;
            this.btnReload.BorderRadius = 18;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.FillColor = System.Drawing.Color.Transparent;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReload.Location = new System.Drawing.Point(113, 79);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(50, 50);
            this.btnReload.TabIndex = 10;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // TicketManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.tabStatus);
            this.Controls.Add(this.label1);
            this.Name = "TicketManagement";
            this.Size = new System.Drawing.Size(1386, 851);
            this.Load += new System.EventHandler(this.TicketManagement_Load);
            this.tabStatus.ResumeLayout(false);
            this.tabStatusWait.ResumeLayout(false);
            this.headerFlowLayout.ResumeLayout(false);
            this.headerFlowLayout.PerformLayout();
            this.tabStatusOK.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tabStatusCancel.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabStatus;
        private System.Windows.Forms.TabPage tabStatusWait;
        private System.Windows.Forms.TabPage tabStatusOK;
        private System.Windows.Forms.TabPage tabStatusCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayouthTabOK;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTabCancel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTabWait;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private Guna.UI2.WinForms.Guna2Panel headerFlowLayout;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNumberAdults;
        private System.Windows.Forms.Label lbNumberChildrens;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCCCD;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}
