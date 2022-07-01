
namespace PBL3.View.tour
{
    partial class FormAddEditTour
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
            this.TourCategory = new System.Windows.Forms.Label();
            this.cbbTourCategory = new System.Windows.Forms.ComboBox();
            this.txtTotalChildren = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTotalAdult = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lbDepartureDate = new System.Windows.Forms.Label();
            this.txtTourName = new System.Windows.Forms.TextBox();
            this.lbTourName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbShortDesc = new System.Windows.Forms.RichTextBox();
            this.htmlDescription = new System.Windows.Forms.WebBrowser();
            this.txtImage = new System.Windows.Forms.Label();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.lbTransport = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTitle = new MyLibrary.MyTextBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TourCategory
            // 
            this.TourCategory.AutoSize = true;
            this.TourCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TourCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.TourCategory.Location = new System.Drawing.Point(45, 232);
            this.TourCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TourCategory.Name = "TourCategory";
            this.TourCategory.Size = new System.Drawing.Size(117, 17);
            this.TourCategory.TabIndex = 71;
            this.TourCategory.Text = "Tour Category:";
            // 
            // cbbTourCategory
            // 
            this.cbbTourCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTourCategory.FormattingEnabled = true;
            this.cbbTourCategory.Location = new System.Drawing.Point(172, 226);
            this.cbbTourCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTourCategory.Name = "cbbTourCategory";
            this.cbbTourCategory.Size = new System.Drawing.Size(231, 25);
            this.cbbTourCategory.TabIndex = 70;
            // 
            // txtTotalChildren
            // 
            this.txtTotalChildren.Enabled = false;
            this.txtTotalChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalChildren.Location = new System.Drawing.Point(841, 145);
            this.txtTotalChildren.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalChildren.Name = "txtTotalChildren";
            this.txtTotalChildren.Size = new System.Drawing.Size(109, 23);
            this.txtTotalChildren.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.label3.Location = new System.Drawing.Point(716, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Price / Children:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(370, 643);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 44);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTotalAdult
            // 
            this.txtTotalAdult.Enabled = false;
            this.txtTotalAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAdult.Location = new System.Drawing.Point(603, 149);
            this.txtTotalAdult.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalAdult.Name = "txtTotalAdult";
            this.txtTotalAdult.Size = new System.Drawing.Size(108, 23);
            this.txtTotalAdult.TabIndex = 54;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.lbTotal.Location = new System.Drawing.Point(485, 151);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(102, 17);
            this.lbTotal.TabIndex = 53;
            this.lbTotal.Text = "Price / Adult:";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.lbDescription.Location = new System.Drawing.Point(63, 489);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(95, 17);
            this.lbDescription.TabIndex = 51;
            this.lbDescription.Text = "Description:";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepartureDate.Location = new System.Drawing.Point(172, 154);
            this.dtpDepartureDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(231, 23);
            this.dtpDepartureDate.TabIndex = 47;
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.lbReturnDate.Location = new System.Drawing.Point(45, 193);
            this.lbReturnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(101, 17);
            this.lbReturnDate.TabIndex = 46;
            this.lbReturnDate.Text = "Return Date:";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnDate.Location = new System.Drawing.Point(172, 189);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(231, 23);
            this.dtpReturnDate.TabIndex = 45;
            // 
            // lbDepartureDate
            // 
            this.lbDepartureDate.AutoSize = true;
            this.lbDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartureDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.lbDepartureDate.Location = new System.Drawing.Point(45, 158);
            this.lbDepartureDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDepartureDate.Name = "lbDepartureDate";
            this.lbDepartureDate.Size = new System.Drawing.Size(125, 17);
            this.lbDepartureDate.TabIndex = 44;
            this.lbDepartureDate.Text = "Departure Date:";
            // 
            // txtTourName
            // 
            this.txtTourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTourName.Location = new System.Drawing.Point(172, 119);
            this.txtTourName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTourName.Name = "txtTourName";
            this.txtTourName.Size = new System.Drawing.Size(231, 23);
            this.txtTourName.TabIndex = 43;
            // 
            // lbTourName
            // 
            this.lbTourName.AutoSize = true;
            this.lbTourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTourName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.lbTourName.Location = new System.Drawing.Point(44, 121);
            this.lbTourName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTourName.Name = "lbTourName";
            this.lbTourName.Size = new System.Drawing.Size(93, 17);
            this.lbTourName.TabIndex = 42;
            this.lbTourName.Text = "Tour Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.label5.Location = new System.Drawing.Point(460, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 72;
            this.label5.Text = "Short Description:";
            // 
            // rtbShortDesc
            // 
            this.rtbShortDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbShortDesc.Location = new System.Drawing.Point(604, 190);
            this.rtbShortDesc.Margin = new System.Windows.Forms.Padding(2);
            this.rtbShortDesc.Name = "rtbShortDesc";
            this.rtbShortDesc.Size = new System.Drawing.Size(346, 195);
            this.rtbShortDesc.TabIndex = 73;
            this.rtbShortDesc.Text = "";
            // 
            // htmlDescription
            // 
            this.htmlDescription.Location = new System.Drawing.Point(191, 439);
            this.htmlDescription.Margin = new System.Windows.Forms.Padding(2);
            this.htmlDescription.MinimumSize = new System.Drawing.Size(15, 16);
            this.htmlDescription.Name = "htmlDescription";
            this.htmlDescription.Size = new System.Drawing.Size(758, 180);
            this.htmlDescription.TabIndex = 77;
            // 
            // txtImage
            // 
            this.txtImage.AutoSize = true;
            this.txtImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.txtImage.Location = new System.Drawing.Point(61, 304);
            this.txtImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(56, 17);
            this.txtImage.TabIndex = 78;
            this.txtImage.Text = "Image:";
            // 
            // panelPicture
            // 
            this.panelPicture.BackColor = System.Drawing.Color.White;
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicture.Location = new System.Drawing.Point(172, 265);
            this.panelPicture.Margin = new System.Windows.Forms.Padding(2);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(231, 123);
            this.panelPicture.TabIndex = 79;
            // 
            // lbTransport
            // 
            this.lbTransport.AutoSize = true;
            this.lbTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.lbTransport.Location = new System.Drawing.Point(484, 120);
            this.lbTransport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTransport.Name = "lbTransport";
            this.lbTransport.Size = new System.Drawing.Size(84, 17);
            this.lbTransport.TabIndex = 81;
            this.lbTransport.Text = "Transport:";
            // 
            // txtTransport
            // 
            this.txtTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransport.Location = new System.Drawing.Point(603, 115);
            this.txtTransport.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(347, 23);
            this.txtTransport.TabIndex = 82;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.panel3.Controls.Add(this.lbTitle);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1135, 43);
            this.panel3.TabIndex = 83;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.lbTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.lbTitle.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lbTitle.BorderRadius = 0;
            this.lbTitle.BorderSize = 2;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(30, 5);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.lbTitle.Multiline = false;
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lbTitle.PasswordChar = false;
            this.lbTitle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lbTitle.PlaceholderText = "";
            this.lbTitle.Size = new System.Drawing.Size(156, 34);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Texts = "";
            this.lbTitle.UnderlinedStyle = true;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnAddImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.ForeColor = System.Drawing.Color.White;
            this.btnAddImage.Image = global::GUI.Properties.Resources._1486485557_add_create_new_more_plus_81188;
            this.btnAddImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddImage.Location = new System.Drawing.Point(64, 330);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(88, 44);
            this.btnAddImage.TabIndex = 80;
            this.btnAddImage.Text = "Add";
            this.btnAddImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Image = global::GUI.Properties.Resources.gui_edit_icon_157165;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(66, 519);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(88, 44);
            this.btnOpen.TabIndex = 76;
            this.btnOpen.Text = "Edit";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::GUI.Properties.Resources.back;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(47, 53);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 37);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::GUI.Properties.Resources.save_file_disk_open_searsh_loading_clipboard_1513;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(682, 643);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 44);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormAddEditTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.lbTransport);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.htmlDescription);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.rtbShortDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TourCategory);
            this.Controls.Add(this.cbbTourCategory);
            this.Controls.Add(this.txtTotalChildren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotalAdult);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.dtpDepartureDate);
            this.Controls.Add(this.lbReturnDate);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.lbDepartureDate);
            this.Controls.Add(this.txtTourName);
            this.Controls.Add(this.lbTourName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddEditTour";
            this.Size = new System.Drawing.Size(1040, 691);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TourCategory;
        private System.Windows.Forms.ComboBox cbbTourCategory;
        private System.Windows.Forms.TextBox txtTotalChildren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTotalAdult;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lbDepartureDate;
        private System.Windows.Forms.TextBox txtTourName;
        private System.Windows.Forms.Label lbTourName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbShortDesc;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.WebBrowser htmlDescription;
        private System.Windows.Forms.Label txtImage;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Label lbTransport;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Panel panel3;
        private MyLibrary.MyTextBox lbTitle;
    }
}
