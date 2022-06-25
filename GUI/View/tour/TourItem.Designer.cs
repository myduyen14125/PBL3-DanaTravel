
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
            this.txtShortDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(755, 194);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 33);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(614, 194);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 33);
            this.btnEdit.TabIndex = 42;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(460, 194);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(65, 33);
            this.btnDetail.TabIndex = 41;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // panelPicture
            // 
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicture.Location = new System.Drawing.Point(14, 21);
            this.panelPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(223, 207);
            this.panelPicture.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(690, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Price/1 Children:";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.Black;
            this.Price.Location = new System.Drawing.Point(279, 57);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(92, 17);
            this.Price.TabIndex = 32;
            this.Price.Text = "Price/1 Adult:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(689, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Category:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.SystemColors.Control;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(279, 21);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 17);
            this.lbName.TabIndex = 30;
            this.lbName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(390, 21);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtName.MaximumSize = new System.Drawing.Size(262, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(39, 16);
            this.txtName.TabIndex = 44;
            this.txtName.Text = "label4";
            // 
            // txtPriceAdult
            // 
            this.txtPriceAdult.AutoSize = true;
            this.txtPriceAdult.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAdult.ForeColor = System.Drawing.Color.Black;
            this.txtPriceAdult.Location = new System.Drawing.Point(390, 57);
            this.txtPriceAdult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPriceAdult.Name = "txtPriceAdult";
            this.txtPriceAdult.Size = new System.Drawing.Size(39, 16);
            this.txtPriceAdult.TabIndex = 45;
            this.txtPriceAdult.Text = "label4";
            // 
            // txtCategory
            // 
            this.txtCategory.AutoSize = true;
            this.txtCategory.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.ForeColor = System.Drawing.Color.Black;
            this.txtCategory.Location = new System.Drawing.Point(813, 21);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(39, 16);
            this.txtCategory.TabIndex = 46;
            this.txtCategory.Text = "label4";
            // 
            // txtPriceChildren
            // 
            this.txtPriceChildren.AutoSize = true;
            this.txtPriceChildren.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceChildren.ForeColor = System.Drawing.Color.Black;
            this.txtPriceChildren.Location = new System.Drawing.Point(813, 51);
            this.txtPriceChildren.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPriceChildren.Name = "txtPriceChildren";
            this.txtPriceChildren.Size = new System.Drawing.Size(39, 16);
            this.txtPriceChildren.TabIndex = 47;
            this.txtPriceChildren.Text = "label4";
            // 
            // lbShortDesc
            // 
            this.lbShortDesc.AutoSize = true;
            this.lbShortDesc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShortDesc.ForeColor = System.Drawing.Color.Black;
            this.lbShortDesc.Location = new System.Drawing.Point(279, 129);
            this.lbShortDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShortDesc.Name = "lbShortDesc";
            this.lbShortDesc.Size = new System.Drawing.Size(77, 17);
            this.lbShortDesc.TabIndex = 48;
            this.lbShortDesc.Text = "Short desc:";
            // 
            // txtShortDesc
            // 
            this.txtShortDesc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortDesc.Location = new System.Drawing.Point(393, 89);
            this.txtShortDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtShortDesc.Multiline = true;
            this.txtShortDesc.Name = "txtShortDesc";
            this.txtShortDesc.Size = new System.Drawing.Size(530, 94);
            this.txtShortDesc.TabIndex = 49;
            // 
            // TourItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtShortDesc);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TourItem";
            this.Size = new System.Drawing.Size(950, 244);
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
        private System.Windows.Forms.TextBox txtShortDesc;
    }
}
