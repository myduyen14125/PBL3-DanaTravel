namespace PBL3.View.admin
{
    partial class CustomerManagement
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
            this.customer1 = new PBL3.View.admin.Customer();
            this.SuspendLayout();
            // 
            // customer1
            // 
            this.customer1.Location = new System.Drawing.Point(41, 24);
            this.customer1.Name = "customer1";
            this.customer1.Size = new System.Drawing.Size(1260, 687);
            this.customer1.TabIndex = 0;
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 773);
            this.Controls.Add(this.customer1);
            this.Name = "CustomerManagement";
            this.Text = "CustomerManagement";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Customer customer1;
    }
}