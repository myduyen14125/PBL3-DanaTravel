namespace PBL3.View.homepage
{
    partial class TourTicketItemView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnViewTour = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.lbTourName = new System.Windows.Forms.Label();
            this.lbNameUser = new System.Windows.Forms.Label();
            this.lbNumberAdult = new System.Windows.Forms.Label();
            this.lbNumberChildren = new System.Windows.Forms.Label();
            this.lbIdentityCard = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(20, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 164);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên tour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng người lớn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng trẻ em:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "CCCD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng tiền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email:";
            // 
            // btnViewTour
            // 
            this.btnViewTour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewTour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewTour.ForeColor = System.Drawing.Color.White;
            this.btnViewTour.Location = new System.Drawing.Point(545, 159);
            this.btnViewTour.Name = "btnViewTour";
            this.btnViewTour.Size = new System.Drawing.Size(127, 33);
            this.btnViewTour.TabIndex = 8;
            this.btnViewTour.Text = "View tour";
            this.btnViewTour.Click += new System.EventHandler(this.btnViewTour_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(703, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 33);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbTourName
            // 
            this.lbTourName.AutoSize = true;
            this.lbTourName.Location = new System.Drawing.Point(292, 19);
            this.lbTourName.Name = "lbTourName";
            this.lbTourName.Size = new System.Drawing.Size(44, 16);
            this.lbTourName.TabIndex = 10;
            this.lbTourName.Text = "label8";
            // 
            // lbNameUser
            // 
            this.lbNameUser.AutoSize = true;
            this.lbNameUser.Location = new System.Drawing.Point(370, 57);
            this.lbNameUser.Name = "lbNameUser";
            this.lbNameUser.Size = new System.Drawing.Size(44, 16);
            this.lbNameUser.TabIndex = 11;
            this.lbNameUser.Text = "label8";
            // 
            // lbNumberAdult
            // 
            this.lbNumberAdult.AutoSize = true;
            this.lbNumberAdult.Location = new System.Drawing.Point(370, 90);
            this.lbNumberAdult.Name = "lbNumberAdult";
            this.lbNumberAdult.Size = new System.Drawing.Size(44, 16);
            this.lbNumberAdult.TabIndex = 12;
            this.lbNumberAdult.Text = "label8";
            // 
            // lbNumberChildren
            // 
            this.lbNumberChildren.AutoSize = true;
            this.lbNumberChildren.Location = new System.Drawing.Point(370, 124);
            this.lbNumberChildren.Name = "lbNumberChildren";
            this.lbNumberChildren.Size = new System.Drawing.Size(44, 16);
            this.lbNumberChildren.TabIndex = 13;
            this.lbNumberChildren.Text = "label8";
            // 
            // lbIdentityCard
            // 
            this.lbIdentityCard.AutoSize = true;
            this.lbIdentityCard.Location = new System.Drawing.Point(674, 57);
            this.lbIdentityCard.Name = "lbIdentityCard";
            this.lbIdentityCard.Size = new System.Drawing.Size(44, 16);
            this.lbIdentityCard.TabIndex = 14;
            this.lbIdentityCard.Text = "label8";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(674, 90);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(44, 16);
            this.lbEmail.TabIndex = 15;
            this.lbEmail.Text = "label8";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(674, 124);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(44, 16);
            this.lbTotalPrice.TabIndex = 16;
            this.lbTotalPrice.Text = "label8";
            // 
            // TourTicketItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbIdentityCard);
            this.Controls.Add(this.lbNumberChildren);
            this.Controls.Add(this.lbNumberAdult);
            this.Controls.Add(this.lbNameUser);
            this.Controls.Add(this.lbTourName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnViewTour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "TourTicketItemView";
            this.Size = new System.Drawing.Size(867, 199);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnViewTour;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label lbTourName;
        private System.Windows.Forms.Label lbNameUser;
        private System.Windows.Forms.Label lbNumberAdult;
        private System.Windows.Forms.Label lbNumberChildren;
        private System.Windows.Forms.Label lbIdentityCard;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTotalPrice;
    }
}
