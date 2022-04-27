namespace PBL3.View
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.cbbTransport = new System.Windows.Forms.ComboBox();
            this.lbTransport = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.lbReturnDay = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.lbDepartureDay = new System.Windows.Forms.Label();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.lbPhoto = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNamePlace = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTourguide = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.btnCalTotal = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(658, 200);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(289, 29);
            this.txtQuantity.TabIndex = 40;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(475, 206);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(127, 23);
            this.lbQuantity.TabIndex = 39;
            this.lbQuantity.Text = "Số lượng người";
            // 
            // cbbTransport
            // 
            this.cbbTransport.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTransport.FormattingEnabled = true;
            this.cbbTransport.Location = new System.Drawing.Point(178, 380);
            this.cbbTransport.Name = "cbbTransport";
            this.cbbTransport.Size = new System.Drawing.Size(242, 31);
            this.cbbTransport.TabIndex = 38;
            // 
            // lbTransport
            // 
            this.lbTransport.AutoSize = true;
            this.lbTransport.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransport.Location = new System.Drawing.Point(38, 388);
            this.lbTransport.Name = "lbTransport";
            this.lbTransport.Size = new System.Drawing.Size(104, 23);
            this.lbTransport.TabIndex = 37;
            this.lbTransport.Text = "Phương tiện";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(658, 105);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(289, 29);
            this.dateTimePickerEnd.TabIndex = 36;
            this.dateTimePickerEnd.TabStop = false;
            this.dateTimePickerEnd.Value = new System.DateTime(2022, 4, 22, 0, 0, 0, 0);
            // 
            // lbReturnDay
            // 
            this.lbReturnDay.AutoSize = true;
            this.lbReturnDay.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnDay.Location = new System.Drawing.Point(475, 105);
            this.lbReturnDay.Name = "lbReturnDay";
            this.lbReturnDay.Size = new System.Drawing.Size(102, 23);
            this.lbReturnDay.TabIndex = 35;
            this.lbReturnDay.Text = "Ngày trở về";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(649, 10);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(298, 29);
            this.dateTimePickerStart.TabIndex = 34;
            this.dateTimePickerStart.TabStop = false;
            this.dateTimePickerStart.Value = new System.DateTime(2022, 4, 22, 0, 0, 0, 0);
            // 
            // lbDepartureDay
            // 
            this.lbDepartureDay.AutoSize = true;
            this.lbDepartureDay.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartureDay.Location = new System.Drawing.Point(475, 13);
            this.lbDepartureDay.Name = "lbDepartureDay";
            this.lbDepartureDay.Size = new System.Drawing.Size(135, 23);
            this.lbDepartureDay.TabIndex = 33;
            this.lbDepartureDay.Text = "Ngày khởi hành";
            // 
            // txtPhoto
            // 
            this.txtPhoto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoto.Location = new System.Drawing.Point(178, 149);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(242, 29);
            this.txtPhoto.TabIndex = 32;
            // 
            // lbPhoto
            // 
            this.lbPhoto.AutoSize = true;
            this.lbPhoto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoto.Location = new System.Drawing.Point(38, 155);
            this.lbPhoto.Name = "lbPhoto";
            this.lbPhoto.Size = new System.Drawing.Size(82, 23);
            this.lbPhoto.TabIndex = 31;
            this.lbPhoto.Text = "Hình ảnh";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(594, 493);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 53);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Hủy ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(335, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 53);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Xác nhận";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNamePlace
            // 
            this.txtNamePlace.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePlace.Location = new System.Drawing.Point(178, 42);
            this.txtNamePlace.Name = "txtNamePlace";
            this.txtNamePlace.Size = new System.Drawing.Size(242, 29);
            this.txtNamePlace.TabIndex = 28;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(38, 48);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(115, 23);
            this.lbName.TabIndex = 27;
            this.lbName.Text = "Tên địa điểm";
            // 
            // lbTourguide
            // 
            this.lbTourguide.AutoSize = true;
            this.lbTourguide.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTourguide.Location = new System.Drawing.Point(475, 312);
            this.lbTourguide.Name = "lbTourguide";
            this.lbTourguide.Size = new System.Drawing.Size(136, 23);
            this.lbTourguide.TabIndex = 41;
            this.lbTourguide.Text = "Hướng dẫn viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Controls.Add(this.rbYes);
            this.groupBox1.Location = new System.Drawing.Point(658, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 44);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(157, 11);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(84, 27);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "Không";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYes.Location = new System.Drawing.Point(34, 11);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(53, 27);
            this.rbYes.TabIndex = 0;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Có";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // btnCalTotal
            // 
            this.btnCalTotal.BackColor = System.Drawing.Color.Yellow;
            this.btnCalTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalTotal.Location = new System.Drawing.Point(479, 387);
            this.btnCalTotal.Name = "btnCalTotal";
            this.btnCalTotal.Size = new System.Drawing.Size(172, 53);
            this.btnCalTotal.TabIndex = 43;
            this.btnCalTotal.Text = "Tổng chi phí";
            this.btnCalTotal.UseVisualStyleBackColor = false;
            this.btnCalTotal.Click += new System.EventHandler(this.btnCalTotal_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.Yellow;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(713, 387);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(172, 53);
            this.btnTotal.TabIndex = 44;
            this.btnTotal.UseVisualStyleBackColor = false;
            // 
            // FormAddEditTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 568);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnCalTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTourguide);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.cbbTransport);
            this.Controls.Add(this.lbTransport);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.lbReturnDay);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.lbDepartureDay);
            this.Controls.Add(this.txtPhoto);
            this.Controls.Add(this.lbPhoto);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNamePlace);
            this.Controls.Add(this.lbName);
            this.Name = "FormAddEditTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddEditTour";
            this.Load += new System.EventHandler(this.FormAddEditTour_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.ComboBox cbbTransport;
        private System.Windows.Forms.Label lbTransport;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label lbReturnDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label lbDepartureDay;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.Label lbPhoto;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNamePlace;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTourguide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Button btnCalTotal;
        private System.Windows.Forms.Button btnTotal;
    }
}