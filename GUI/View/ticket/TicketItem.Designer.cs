namespace PBL3.View.ticket
{
    partial class TicketItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketItem));
            this.lbName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbNumberAdults = new System.Windows.Forms.Label();
            this.lbNumberChildren = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.btnAccept = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(2, 10);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(423, 10);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(30, 13);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Date";
            // 
            // lbNumberAdults
            // 
            this.lbNumberAdults.AutoSize = true;
            this.lbNumberAdults.Location = new System.Drawing.Point(490, 10);
            this.lbNumberAdults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumberAdults.Name = "lbNumberAdults";
            this.lbNumberAdults.Size = new System.Drawing.Size(26, 13);
            this.lbNumberAdults.TabIndex = 2;
            this.lbNumberAdults.Text = "SLL";
            // 
            // lbNumberChildren
            // 
            this.lbNumberChildren.AutoSize = true;
            this.lbNumberChildren.Location = new System.Drawing.Point(531, 10);
            this.lbNumberChildren.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumberChildren.Name = "lbNumberChildren";
            this.lbNumberChildren.Size = new System.Drawing.Size(28, 13);
            this.lbNumberChildren.TabIndex = 3;
            this.lbNumberChildren.Text = "SLN";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(128, 10);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            // 
            // lbCCCD
            // 
            this.lbCCCD.AutoSize = true;
            this.lbCCCD.Location = new System.Drawing.Point(262, 10);
            this.lbCCCD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(36, 13);
            this.lbCCCD.TabIndex = 5;
            this.lbCCCD.Text = "CCCD";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(349, 10);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(38, 13);
            this.lbPhone.TabIndex = 6;
            this.lbPhone.Text = "Phone";
            // 
            // btnAccept
            // 
            this.btnAccept.BorderRadius = 20;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccept.FillColor = System.Drawing.Color.Transparent;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAccept.Location = new System.Drawing.Point(568, 0);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(30, 32);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(617, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(30, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TicketItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbCCCD);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNumberChildren);
            this.Controls.Add(this.lbNumberAdults);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Name = "TicketItem";
            this.Size = new System.Drawing.Size(654, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbNumberAdults;
        private System.Windows.Forms.Label lbNumberChildren;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCCCD;
        private System.Windows.Forms.Label lbPhone;
        private Guna.UI2.WinForms.Guna2Button btnAccept;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
