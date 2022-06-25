namespace PBL3.View.homepage
{
    partial class FormHistoryTransaction
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
            this.tabStatus = new System.Windows.Forms.TabControl();
            this.tabStatusWaitConfirm = new System.Windows.Forms.TabPage();
            this.flowLayoutTabWaitConfirm = new System.Windows.Forms.FlowLayoutPanel();
            this.tabStatusWaitPay = new System.Windows.Forms.TabPage();
            this.flowLayoutTabWaitPay = new System.Windows.Forms.FlowLayoutPanel();
            this.tabStatusOk = new System.Windows.Forms.TabPage();
            this.flowLayoutTabOk = new System.Windows.Forms.FlowLayoutPanel();
            this.tabStatusCancel = new System.Windows.Forms.TabPage();
            this.flowLayoutTabCancel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.myTextBox1 = new MyLibrary.MyTextBox();
            this.tabStatus.SuspendLayout();
            this.tabStatusWaitConfirm.SuspendLayout();
            this.tabStatusWaitPay.SuspendLayout();
            this.tabStatusOk.SuspendLayout();
            this.tabStatusCancel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.tabStatusWaitConfirm);
            this.tabStatus.Controls.Add(this.tabStatusWaitPay);
            this.tabStatus.Controls.Add(this.tabStatusOk);
            this.tabStatus.Controls.Add(this.tabStatusCancel);
            this.tabStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabStatus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabStatus.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabStatus.ItemSize = new System.Drawing.Size(150, 30);
            this.tabStatus.Location = new System.Drawing.Point(9, 54);
            this.tabStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.SelectedIndex = 0;
            this.tabStatus.Size = new System.Drawing.Size(905, 506);
            this.tabStatus.TabIndex = 3;
            this.tabStatus.SelectedIndexChanged += new System.EventHandler(this.tabStatus_SelectedIndexChanged);
            // 
            // tabStatusWaitConfirm
            // 
            this.tabStatusWaitConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatusWaitConfirm.Controls.Add(this.flowLayoutTabWaitConfirm);
            this.tabStatusWaitConfirm.Location = new System.Drawing.Point(4, 34);
            this.tabStatusWaitConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabStatusWaitConfirm.Name = "tabStatusWaitConfirm";
            this.tabStatusWaitConfirm.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabStatusWaitConfirm.Size = new System.Drawing.Size(897, 468);
            this.tabStatusWaitConfirm.TabIndex = 0;
            this.tabStatusWaitConfirm.Text = "Đang chờ xác nhận";
            this.tabStatusWaitConfirm.UseVisualStyleBackColor = true;
            // 
            // flowLayoutTabWaitConfirm
            // 
            this.flowLayoutTabWaitConfirm.AutoScroll = true;
            this.flowLayoutTabWaitConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutTabWaitConfirm.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutTabWaitConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutTabWaitConfirm.Name = "flowLayoutTabWaitConfirm";
            this.flowLayoutTabWaitConfirm.Size = new System.Drawing.Size(891, 462);
            this.flowLayoutTabWaitConfirm.TabIndex = 0;
            // 
            // tabStatusWaitPay
            // 
            this.tabStatusWaitPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatusWaitPay.Controls.Add(this.flowLayoutTabWaitPay);
            this.tabStatusWaitPay.Location = new System.Drawing.Point(4, 34);
            this.tabStatusWaitPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabStatusWaitPay.Name = "tabStatusWaitPay";
            this.tabStatusWaitPay.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabStatusWaitPay.Size = new System.Drawing.Size(897, 468);
            this.tabStatusWaitPay.TabIndex = 1;
            this.tabStatusWaitPay.Text = "Đang chờ thanh toán";
            this.tabStatusWaitPay.UseVisualStyleBackColor = true;
            // 
            // flowLayoutTabWaitPay
            // 
            this.flowLayoutTabWaitPay.AutoScroll = true;
            this.flowLayoutTabWaitPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutTabWaitPay.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutTabWaitPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutTabWaitPay.Name = "flowLayoutTabWaitPay";
            this.flowLayoutTabWaitPay.Size = new System.Drawing.Size(891, 462);
            this.flowLayoutTabWaitPay.TabIndex = 5;
            // 
            // tabStatusOk
            // 
            this.tabStatusOk.Controls.Add(this.flowLayoutTabOk);
            this.tabStatusOk.Location = new System.Drawing.Point(4, 34);
            this.tabStatusOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabStatusOk.Name = "tabStatusOk";
            this.tabStatusOk.Size = new System.Drawing.Size(897, 468);
            this.tabStatusOk.TabIndex = 3;
            this.tabStatusOk.Text = "Đã thanh toán";
            this.tabStatusOk.UseVisualStyleBackColor = true;
            // 
            // flowLayoutTabOk
            // 
            this.flowLayoutTabOk.AutoScroll = true;
            this.flowLayoutTabOk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutTabOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutTabOk.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutTabOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutTabOk.Name = "flowLayoutTabOk";
            this.flowLayoutTabOk.Size = new System.Drawing.Size(897, 468);
            this.flowLayoutTabOk.TabIndex = 0;
            // 
            // tabStatusCancel
            // 
            this.tabStatusCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatusCancel.Controls.Add(this.flowLayoutTabCancel);
            this.tabStatusCancel.Location = new System.Drawing.Point(4, 34);
            this.tabStatusCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabStatusCancel.Name = "tabStatusCancel";
            this.tabStatusCancel.Size = new System.Drawing.Size(897, 468);
            this.tabStatusCancel.TabIndex = 2;
            this.tabStatusCancel.Text = "Đã bị hủy";
            this.tabStatusCancel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutTabCancel
            // 
            this.flowLayoutTabCancel.AutoScroll = true;
            this.flowLayoutTabCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutTabCancel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutTabCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutTabCancel.Name = "flowLayoutTabCancel";
            this.flowLayoutTabCancel.Size = new System.Drawing.Size(895, 466);
            this.flowLayoutTabCancel.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.panel3.Controls.Add(this.myTextBox1);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1135, 43);
            this.panel3.TabIndex = 29;
            // 
            // myTextBox1
            // 
            this.myTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.myTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.myTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.myTextBox1.BorderRadius = 0;
            this.myTextBox1.BorderSize = 2;
            this.myTextBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTextBox1.ForeColor = System.Drawing.Color.White;
            this.myTextBox1.Location = new System.Drawing.Point(30, 5);
            this.myTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.myTextBox1.Multiline = false;
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.myTextBox1.PasswordChar = false;
            this.myTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.myTextBox1.PlaceholderText = "";
            this.myTextBox1.Size = new System.Drawing.Size(149, 34);
            this.myTextBox1.TabIndex = 1;
            this.myTextBox1.Texts = "Lịch sử đặt Tour";
            this.myTextBox1.UnderlinedStyle = true;
            // 
            // FormHistoryTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(939, 607);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabStatus);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHistoryTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHistoryTransaction";
            this.Load += new System.EventHandler(this.FormHistoryTransaction_Load);
            this.tabStatus.ResumeLayout(false);
            this.tabStatusWaitConfirm.ResumeLayout(false);
            this.tabStatusWaitPay.ResumeLayout(false);
            this.tabStatusOk.ResumeLayout(false);
            this.tabStatusCancel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStatus;
        private System.Windows.Forms.TabPage tabStatusWaitConfirm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTabWaitConfirm;
        private System.Windows.Forms.TabPage tabStatusWaitPay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTabWaitPay;
        private System.Windows.Forms.TabPage tabStatusCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTabCancel;
        private System.Windows.Forms.TabPage tabStatusOk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTabOk;
        private System.Windows.Forms.Panel panel3;
        private MyLibrary.MyTextBox myTextBox1;
    }
}