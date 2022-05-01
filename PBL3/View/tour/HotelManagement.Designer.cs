
namespace PBL3.View.tour
{
    partial class HotelManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutHotel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(518, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel";
            // 
            // flowLayoutHotel
            // 
            this.flowLayoutHotel.AutoScroll = true;
            this.flowLayoutHotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutHotel.Location = new System.Drawing.Point(93, 144);
            this.flowLayoutHotel.Name = "flowLayoutHotel";
            this.flowLayoutHotel.Size = new System.Drawing.Size(1014, 471);
            this.flowLayoutHotel.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(93, 63);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(107, 38);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // HotelManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.flowLayoutHotel);
            this.Controls.Add(this.label1);
            this.Name = "HotelManagement";
            this.Size = new System.Drawing.Size(1190, 670);
            this.Load += new System.EventHandler(this.HotelManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutHotel;
        private System.Windows.Forms.Button btnCreate;
    }
}
