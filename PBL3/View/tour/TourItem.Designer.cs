
namespace PBL3.View.tour
{
    partial class TourItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TourItem));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtPriceAdult = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.Label();
            this.txtPriceChildren = new System.Windows.Forms.Label();
            this.lbShortDesc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtShortDesc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(829, 223);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 41);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(619, 223);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 41);
            this.btnEdit.TabIndex = 42;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.Location = new System.Drawing.Point(399, 223);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(82, 41);
            this.btnDetail.TabIndex = 41;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // panelPicture
            // 
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicture.Location = new System.Drawing.Point(19, 26);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(257, 226);
            this.panelPicture.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Price/1 Children:";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(282, 75);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(92, 17);
            this.Price.TabIndex = 32;
            this.Price.Text = "Price/1 Adult:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Category:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(282, 26);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 17);
            this.lbName.TabIndex = 30;
            this.lbName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(396, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(46, 17);
            this.txtName.TabIndex = 44;
            this.txtName.Text = "label4";
            // 
            // txtPriceAdult
            // 
            this.txtPriceAdult.AutoSize = true;
            this.txtPriceAdult.Location = new System.Drawing.Point(396, 75);
            this.txtPriceAdult.Name = "txtPriceAdult";
            this.txtPriceAdult.Size = new System.Drawing.Size(46, 17);
            this.txtPriceAdult.TabIndex = 45;
            this.txtPriceAdult.Text = "label4";
            // 
            // txtCategory
            // 
            this.txtCategory.AutoSize = true;
            this.txtCategory.Location = new System.Drawing.Point(807, 26);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(46, 17);
            this.txtCategory.TabIndex = 46;
            this.txtCategory.Text = "label4";
            // 
            // txtPriceChildren
            // 
            this.txtPriceChildren.AutoSize = true;
            this.txtPriceChildren.Location = new System.Drawing.Point(807, 75);
            this.txtPriceChildren.Name = "txtPriceChildren";
            this.txtPriceChildren.Size = new System.Drawing.Size(46, 17);
            this.txtPriceChildren.TabIndex = 47;
            this.txtPriceChildren.Text = "label4";
            // 
            // lbShortDesc
            // 
            this.lbShortDesc.AutoSize = true;
            this.lbShortDesc.Location = new System.Drawing.Point(282, 151);
            this.lbShortDesc.Name = "lbShortDesc";
            this.lbShortDesc.Size = new System.Drawing.Size(80, 17);
            this.lbShortDesc.TabIndex = 48;
            this.lbShortDesc.Text = "Short desc:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtShortDesc);
            this.panel1.Location = new System.Drawing.Point(399, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 86);
            this.panel1.TabIndex = 49;
            // 
            // txtShortDesc
            // 
            this.txtShortDesc.AutoSize = true;
            this.txtShortDesc.Location = new System.Drawing.Point(3, 0);
            this.txtShortDesc.Name = "txtShortDesc";
            this.txtShortDesc.Size = new System.Drawing.Size(46, 17);
            this.txtShortDesc.TabIndex = 0;
            this.txtShortDesc.Text = "label1";
            // 
            // TourItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbShortDesc);
            this.Controls.Add(this.txtPriceChildren);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPriceAdult);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbName);
            this.Name = "TourItem";
            this.Size = new System.Drawing.Size(989, 275);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtPriceAdult;
        private System.Windows.Forms.Label txtCategory;
        private System.Windows.Forms.Label txtPriceChildren;
        private System.Windows.Forms.Label lbShortDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtShortDesc;
    }
}
