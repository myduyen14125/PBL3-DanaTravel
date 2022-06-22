namespace PBL3.View
{
    partial class TourManagement
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.totalLb = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.myTextBox1 = new MyLibrary.MyTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutTours = new System.Windows.Forms.FlowLayoutPanel();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbbTourCategory = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1151, 163);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 44);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(883, 170);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 35);
            this.txtSearch.TabIndex = 15;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(150, 86);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(84, 28);
            this.txtTotal.TabIndex = 12;
            // 
            // totalLb
            // 
            this.totalLb.AutoSize = true;
            this.totalLb.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.totalLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.totalLb.Location = new System.Drawing.Point(35, 89);
            this.totalLb.Name = "totalLb";
            this.totalLb.Size = new System.Drawing.Size(67, 25);
            this.totalLb.TabIndex = 11;
            this.totalLb.Text = "Total:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.panel3.Controls.Add(this.myTextBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1513, 53);
            this.panel3.TabIndex = 28;
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
            this.myTextBox1.Location = new System.Drawing.Point(40, 6);
            this.myTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.myTextBox1.Multiline = false;
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.myTextBox1.PasswordChar = false;
            this.myTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.myTextBox1.PlaceholderText = "";
            this.myTextBox1.Size = new System.Drawing.Size(129, 44);
            this.myTextBox1.TabIndex = 1;
            this.myTextBox1.Texts = "Tour";
            this.myTextBox1.UnderlinedStyle = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(0, 811);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1750, 40);
            this.panel2.TabIndex = 29;
            // 
            // flowLayoutTours
            // 
            this.flowLayoutTours.AutoScroll = true;
            this.flowLayoutTours.BackColor = System.Drawing.Color.White;
            this.flowLayoutTours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutTours.Location = new System.Drawing.Point(40, 246);
            this.flowLayoutTours.Name = "flowLayoutTours";
            this.flowLayoutTours.Size = new System.Drawing.Size(1300, 558);
            this.flowLayoutTours.TabIndex = 31;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.lbCategory.Location = new System.Drawing.Point(406, 180);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(155, 25);
            this.lbCategory.TabIndex = 32;
            this.lbCategory.Text = "Tour Category:";
            // 
            // cbbTourCategory
            // 
            this.cbbTourCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTourCategory.FormattingEnabled = true;
            this.cbbTourCategory.Location = new System.Drawing.Point(607, 177);
            this.cbbTourCategory.Name = "cbbTourCategory";
            this.cbbTourCategory.Size = new System.Drawing.Size(150, 30);
            this.cbbTourCategory.TabIndex = 33;
            this.cbbTourCategory.SelectedIndexChanged += new System.EventHandler(this.cbbTourCategory_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(552, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(40, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 45);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add tour";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TourManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbTourCategory);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.totalLb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutTours);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TourManagement";
            this.Size = new System.Drawing.Size(1386, 851);
            this.Load += new System.EventHandler(this.TourManagement_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label totalLb;
        private System.Windows.Forms.Panel panel3;
        private MyLibrary.MyTextBox myTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTours;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbbTourCategory;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}
