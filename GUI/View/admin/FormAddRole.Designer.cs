
namespace PBL3.View.admin
{
    partial class FormAddRole
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.dataGridViewPermission = new System.Windows.Forms.DataGridView();
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role Name:";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(142, 16);
            this.txtRole.Margin = new System.Windows.Forms.Padding(2);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(162, 20);
            this.txtRole.TabIndex = 1;
            // 
            // dataGridViewPermission
            // 
            this.dataGridViewPermission.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPermission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPermission.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewPermission.Location = new System.Drawing.Point(18, 60);
            this.dataGridViewPermission.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPermission.Name = "dataGridViewPermission";
            this.dataGridViewPermission.RowHeadersWidth = 51;
            this.dataGridViewPermission.RowTemplate.Height = 24;
            this.dataGridViewPermission.Size = new System.Drawing.Size(560, 245);
            this.dataGridViewPermission.TabIndex = 2;
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnCreateRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateRole.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnCreateRole.ForeColor = System.Drawing.Color.White;
            this.btnCreateRole.Image = global::GUI.Properties.Resources._1486485557_add_create_new_more_plus_81188;
            this.btnCreateRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateRole.Location = new System.Drawing.Point(431, 321);
            this.btnCreateRole.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(95, 35);
            this.btnCreateRole.TabIndex = 3;
            this.btnCreateRole.Text = "Create ";
            this.btnCreateRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateRole.UseVisualStyleBackColor = false;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::GUI.Properties.Resources.Cancel_40972;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(121, 321);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "      Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateRole);
            this.Controls.Add(this.dataGridViewPermission);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddRole";
            this.Text = "FormAddRole";
            this.Load += new System.EventHandler(this.FormAddRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.DataGridView dataGridViewPermission;
        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.Button btnCancel;
    }
}