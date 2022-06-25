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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartSale = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStatistic = new Guna.UI2.WinForms.Guna2Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonthTo = new System.Windows.Forms.TextBox();
            this.txtMonthFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label5 = new System.Windows.Forms.Label();
            this.dataTourOutStanding = new System.Windows.Forms.DataGridView();
            this.TourName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.myTextBox1 = new MyLibrary.MyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTourOutStanding)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSale
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSale.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSale.Legends.Add(legend2);
            this.chartSale.Location = new System.Drawing.Point(15, 436);
            this.chartSale.Margin = new System.Windows.Forms.Padding(2);
            this.chartSale.Name = "chartSale";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Doanh thu";
            series2.Name = "chartSale";
            this.chartSale.Series.Add(series2);
            this.chartSale.Size = new System.Drawing.Size(994, 242);
            this.chartSale.TabIndex = 2;
            this.chartSale.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "Biểu đồ thống kê doanh thu";
            this.chartSale.Titles.Add(title2);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnStatistic.BorderColor = System.Drawing.Color.White;
            this.btnStatistic.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnStatistic.BorderThickness = 2;
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.CustomBorderColor = System.Drawing.Color.White;
            this.btnStatistic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatistic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatistic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.btnStatistic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStatistic.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.Location = new System.Drawing.Point(914, 73);
            this.btnStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(96, 27);
            this.btnStatistic.TabIndex = 14;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(826, 77);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(47, 20);
            this.txtYear.TabIndex = 13;
            // 
            // txtMonthTo
            // 
            this.txtMonthTo.Location = new System.Drawing.Point(694, 77);
            this.txtMonthTo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonthTo.Name = "txtMonthTo";
            this.txtMonthTo.Size = new System.Drawing.Size(47, 20);
            this.txtMonthTo.TabIndex = 12;
            // 
            // txtMonthFrom
            // 
            this.txtMonthFrom.Location = new System.Drawing.Point(587, 77);
            this.txtMonthFrom.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonthFrom.Name = "txtMonthFrom";
            this.txtMonthFrom.Size = new System.Drawing.Size(47, 20);
            this.txtMonthFrom.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(774, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Năm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(650, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(527, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tháng:";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(86, 128);
            this.pieChart1.Margin = new System.Windows.Forms.Padding(2);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(276, 304);
            this.pieChart1.TabIndex = 16;
            this.pieChart1.Text = "pieChart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.label5.Location = new System.Drawing.Point(145, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Các tour nổi bật";
            // 
            // dataTourOutStanding
            // 
            this.dataTourOutStanding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTourOutStanding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TourName,
            this.TourPrice,
            this.PercentSale});
            this.dataTourOutStanding.Location = new System.Drawing.Point(437, 145);
            this.dataTourOutStanding.Margin = new System.Windows.Forms.Padding(2);
            this.dataTourOutStanding.Name = "dataTourOutStanding";
            this.dataTourOutStanding.RowHeadersWidth = 51;
            this.dataTourOutStanding.RowTemplate.Height = 24;
            this.dataTourOutStanding.Size = new System.Drawing.Size(566, 271);
            this.dataTourOutStanding.TabIndex = 18;
            // 
            // TourName
            // 
            this.TourName.HeaderText = "Tên tour";
            this.TourName.MinimumWidth = 6;
            this.TourName.Name = "TourName";
            this.TourName.Width = 262;
            // 
            // TourPrice
            // 
            this.TourPrice.HeaderText = "Doanh thu tour";
            this.TourPrice.MinimumWidth = 6;
            this.TourPrice.Name = "TourPrice";
            this.TourPrice.Width = 150;
            // 
            // PercentSale
            // 
            this.PercentSale.HeaderText = "Phần trăm";
            this.PercentSale.MinimumWidth = 6;
            this.PercentSale.Name = "PercentSale";
            this.PercentSale.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(142)))));
            this.label6.Location = new System.Drawing.Point(437, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tổng doanh thu:";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalPrice.Location = new System.Drawing.Point(584, 112);
            this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalPrice.MinimumSize = new System.Drawing.Size(150, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(150, 17);
            this.lbTotalPrice.TabIndex = 20;
            this.lbTotalPrice.Text = "Tổng doanh thu:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.panel3.Controls.Add(this.myTextBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 43);
            this.panel3.TabIndex = 30;
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
            this.myTextBox1.Location = new System.Drawing.Point(30, 5);
            this.myTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.myTextBox1.Multiline = false;
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.myTextBox1.PasswordChar = false;
            this.myTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.myTextBox1.PlaceholderText = "";
            this.myTextBox1.Size = new System.Drawing.Size(94, 34);
            this.myTextBox1.TabIndex = 1;
            this.myTextBox1.Texts = "Thống kê";
            this.myTextBox1.UnderlinedStyle = true;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataTourOutStanding);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonthTo);
            this.Controls.Add(this.txtMonthFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartSale);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Statistic";
            this.Size = new System.Drawing.Size(1040, 691);
            this.Load += new System.EventHandler(this.Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTourOutStanding)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSale;
        private Guna.UI2.WinForms.Guna2Button btnStatistic;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonthTo;
        private System.Windows.Forms.TextBox txtMonthFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataTourOutStanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentSale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Panel panel3;
        private MyLibrary.MyTextBox myTextBox1;
    }
}
