
namespace PBL3
{
    partial class Form1
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
            this.hotelManagement1 = new PBL3.View.tour.HotelManagement();
            this.SuspendLayout();
            // 
            // hotelManagement1
            // 
            this.hotelManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotelManagement1.Location = new System.Drawing.Point(0, 0);
            this.hotelManagement1.Name = "hotelManagement1";
            this.hotelManagement1.Size = new System.Drawing.Size(800, 450);
            this.hotelManagement1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hotelManagement1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private View.tour.HotelManagement hotelManagement1;
    }
}