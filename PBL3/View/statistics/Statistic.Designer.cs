namespace PBL3.View.statistics
{
    partial class Statistic
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(47, 58);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(826, 458);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cartesianChart1);
            this.Name = "Statistic";
            this.Size = new System.Drawing.Size(1245, 746);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}
