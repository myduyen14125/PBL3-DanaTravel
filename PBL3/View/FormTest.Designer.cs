
namespace PBL3.View
{
    partial class FormTest
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
            this.transportManagement1 = new PBL3.View.tour.TransportManagement();
            this.SuspendLayout();
            // 
            // transportManagement1
            // 
            this.transportManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transportManagement1.Location = new System.Drawing.Point(0, 0);
            this.transportManagement1.Name = "transportManagement1";
            this.transportManagement1.Size = new System.Drawing.Size(800, 450);
            this.transportManagement1.TabIndex = 0;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transportManagement1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);

        }

        #endregion

        private tour.TransportManagement transportManagement1;
    }
}