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
            this.label1 = new System.Windows.Forms.Label();
            this.tabStatus = new System.Windows.Forms.TabControl();
            this.tabStatusWait = new System.Windows.Forms.TabPage();
            this.flowLayoutTabWait = new System.Windows.Forms.FlowLayoutPanel();
            this.tabStatusOK = new System.Windows.Forms.TabPage();
            this.flowLayouthTabOK = new System.Windows.Forms.FlowLayoutPanel();
            this.tabStatusCancel = new System.Windows.Forms.TabPage();
            this.flowLayoutTabControl = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabStatus.SuspendLayout();
            this.tabStatusWait.SuspendLayout();
            this.tabStatusOK.SuspendLayout();
            this.tabStatusCancel.SuspendLayout();
            //this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(425, 23);
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
            this.tabStatus.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabStatus.ItemSize = new System.Drawing.Size(150, 30);
            this.tabStatus.Location = new System.Drawing.Point(35, 94);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.SelectedIndex = 0;
            this.tabStatus.Size = new System.Drawing.Size(1081, 551);
            this.tabStatus.TabIndex = 2;
            // 
            // tabStatusWait
            // 
            this.tabStatusWait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatusWait.Controls.Add(this.flowLayoutTabWait);
            this.tabStatusWait.Location = new System.Drawing.Point(4, 34);
            this.tabStatusWait.Name = "tabStatusWait";
            this.tabStatusWait.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusWait.Size = new System.Drawing.Size(1073, 513);
            this.tabStatusWait.TabIndex = 0;
            this.tabStatusWait.Text = "Đang chờ xác nhận";
            this.tabStatusWait.UseVisualStyleBackColor = true;
            // 
            // flowLayoutTabWait
            // 
            this.flowLayoutTabWait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutTabWait.Location = new System.Drawing.Point(35, 46);
            this.flowLayoutTabWait.Name = "flowLayoutTabWait";
            this.flowLayoutTabWait.Size = new System.Drawing.Size(998, 434);
            this.flowLayoutTabWait.TabIndex = 0;
            // 
            // tabStatusOK
            // 
            this.tabStatusOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatusOK.Controls.Add(this.flowLayouthTabOK);
            this.tabStatusOK.Location = new System.Drawing.Point(4, 34);
            this.tabStatusOK.Name = "tabStatusOK";
            this.tabStatusOK.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusOK.Size = new System.Drawing.Size(1073, 513);
            this.tabStatusOK.TabIndex = 1;
            this.tabStatusOK.Text = "Đã xác nhận";
            this.tabStatusOK.UseVisualStyleBackColor = true;
            // 
            // flowLayouthTabOK
            // 
            this.flowLayouthTabOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayouthTabOK.Location = new System.Drawing.Point(25, 33);
            this.flowLayouthTabOK.Name = "flowLayouthTabOK";
            this.flowLayouthTabOK.Size = new System.Drawing.Size(1021, 439);
            this.flowLayouthTabOK.TabIndex = 5;
            // 
            // tabStatusCancel
            // 
            this.tabStatusCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatusCancel.Controls.Add(this.flowLayoutTabControl);
            this.tabStatusCancel.Location = new System.Drawing.Point(4, 34);
            this.tabStatusCancel.Name = "tabStatusCancel";
            this.tabStatusCancel.Size = new System.Drawing.Size(1073, 513);
            this.tabStatusCancel.TabIndex = 2;
            this.tabStatusCancel.Text = "Đã bị hủy";
            this.tabStatusCancel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutTabControl
            // 
            this.flowLayoutTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutTabControl.Location = new System.Drawing.Point(25, 25);
            this.flowLayoutTabControl.Name = "flowLayoutTabControl";
            this.flowLayoutTabControl.Size = new System.Drawing.Size(1017, 449);
            this.flowLayoutTabControl.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(823, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1041, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // TicketManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.tabStatus);
            this.Controls.Add(this.label1);
            this.Name = "TicketManagement";
            this.Size = new System.Drawing.Size(1176, 678);
            this.tabStatus.ResumeLayout(false);
            this.tabStatusWait.ResumeLayout(false);
            this.tabStatusOK.ResumeLayout(false);
            this.tabStatusCancel.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTabControl;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTabWait;
    }
}
