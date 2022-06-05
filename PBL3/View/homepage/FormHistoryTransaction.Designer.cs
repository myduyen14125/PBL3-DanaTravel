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
            this.label1 = new System.Windows.Forms.Label();
            this.tabStatus.SuspendLayout();
            this.tabStatusWaitConfirm.SuspendLayout();
            this.tabStatusWaitPay.SuspendLayout();
            this.tabStatusOk.SuspendLayout();
            this.tabStatusCancel.SuspendLayout();
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
            this.tabStatus.Location = new System.Drawing.Point(12, 67);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.SelectedIndex = 0;
            this.tabStatus.Size = new System.Drawing.Size(1207, 623);
            this.tabStatus.TabIndex = 3;
            this.tabStatus.SelectedIndexChanged += new System.EventHandler(this.tabStatus_SelectedIndexChanged);
            // 
            // tabStatusWaitConfirm
            // 
            this.tabStatusWaitConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatusWaitConfirm.Controls.Add(this.flowLayoutTabWaitConfirm);
            this.tabStatusWaitConfirm.Location = new System.Drawing.Point(4, 34);
            this.tabStatusWaitConfirm.Name = "tabStatusWaitConfirm";
            this.tabStatusWaitConfirm.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusWaitConfirm.Size = new System.Drawing.Size(1199, 585);
            this.tabStatusWaitConfirm.TabIndex = 0;
            this.tabStatusWaitConfirm.Text = "Đang chờ xác nhận";
            this.tabStatusWaitConfirm.UseVisualStyleBackColor = true;
            // 
            // flowLayoutTabWaitConfirm
            // 
            this.flowLayoutTabWaitConfirm.AutoScroll = true;
            this.flowLayoutTabWaitConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutTabWaitConfirm.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutTabWaitConfirm.Name = "flowLayoutTabWaitConfirm";
            this.flowLayoutTabWaitConfirm.Size = new System.Drawing.Size(1191, 577);
            this.flowLayoutTabWaitConfirm.TabIndex = 0;
            // 
            // tabStatusWaitPay
            // 
            this.tabStatusWaitPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatusWaitPay.Controls.Add(this.flowLayoutTabWaitPay);
            this.tabStatusWaitPay.Location = new System.Drawing.Point(4, 34);
            this.tabStatusWaitPay.Name = "tabStatusWaitPay";
            this.tabStatusWaitPay.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusWaitPay.Size = new System.Drawing.Size(1199, 585);
            this.tabStatusWaitPay.TabIndex = 1;
            this.tabStatusWaitPay.Text = "Đang chờ thanh toán";
            this.tabStatusWaitPay.UseVisualStyleBackColor = true;
            // 
            // flowLayoutTabWaitPay
            // 
            this.flowLayoutTabWaitPay.AutoScroll = true;
            this.flowLayoutTabWaitPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutTabWaitPay.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutTabWaitPay.Name = "flowLayoutTabWaitPay";
            this.flowLayoutTabWaitPay.Size = new System.Drawing.Size(1191, 577);
            this.flowLayoutTabWaitPay.TabIndex = 5;
            // 
            // tabStatusOk
            // 
            this.tabStatusOk.Controls.Add(this.flowLayoutTabOk);
            this.tabStatusOk.Location = new System.Drawing.Point(4, 34);
            this.tabStatusOk.Name = "tabStatusOk";
            this.tabStatusOk.Size = new System.Drawing.Size(1199, 585);
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
            this.flowLayoutTabOk.Name = "flowLayoutTabOk";
            this.flowLayoutTabOk.Size = new System.Drawing.Size(1199, 585);
            this.flowLayoutTabOk.TabIndex = 0;
            // 
            // tabStatusCancel
            // 
            this.tabStatusCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatusCancel.Controls.Add(this.flowLayoutTabCancel);
            this.tabStatusCancel.Location = new System.Drawing.Point(4, 34);
            this.tabStatusCancel.Name = "tabStatusCancel";
            this.tabStatusCancel.Size = new System.Drawing.Size(1199, 585);
            this.tabStatusCancel.TabIndex = 2;
            this.tabStatusCancel.Text = "Đã bị hủy";
            this.tabStatusCancel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutTabCancel
            // 
            this.flowLayoutTabCancel.AutoScroll = true;
            this.flowLayoutTabCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutTabCancel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutTabCancel.Name = "flowLayoutTabCancel";
            this.flowLayoutTabCancel.Size = new System.Drawing.Size(1197, 583);
            this.flowLayoutTabCancel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.label1.Location = new System.Drawing.Point(506, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lịch sử đặt tour";
            // 
            // FormHistoryTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1252, 747);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabStatus);
            this.Name = "FormHistoryTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHistoryTransaction";
            this.Load += new System.EventHandler(this.FormHistoryTransaction_Load);
            this.tabStatus.ResumeLayout(false);
            this.tabStatusWaitConfirm.ResumeLayout(false);
            this.tabStatusWaitPay.ResumeLayout(false);
            this.tabStatusOk.ResumeLayout(false);
            this.tabStatusCancel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}