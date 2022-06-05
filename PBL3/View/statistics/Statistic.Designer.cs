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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartSale = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStatistic = new Guna.UI2.WinForms.Guna2Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonthTo = new System.Windows.Forms.TextBox();
            this.txtMonthFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label5 = new System.Windows.Forms.Label();
            this.dataTourOutStanding = new System.Windows.Forms.DataGridView();
            this.TourName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTourOutStanding)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSale
            // 
            chartArea5.Name = "ChartArea1";
            this.chartSale.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartSale.Legends.Add(legend5);
            this.chartSale.Location = new System.Drawing.Point(36, 551);
            this.chartSale.Name = "chartSale";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.LegendText = "Doanh thu";
            series5.Name = "chartSale";
            this.chartSale.Series.Add(series5);
            this.chartSale.Size = new System.Drawing.Size(1310, 283);
            this.chartSale.TabIndex = 2;
            this.chartSale.Text = "chart1";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            title5.Name = "Title1";
            title5.Text = "Biểu đồ thống kê doanh thu";
            this.chartSale.Titles.Add(title5);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BorderRadius = 5;
            this.btnStatistic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatistic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatistic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatistic.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.Location = new System.Drawing.Point(1218, 90);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(128, 33);
            this.btnStatistic.TabIndex = 14;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(1101, 95);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(61, 22);
            this.txtYear.TabIndex = 13;
            // 
            // txtMonthTo
            // 
            this.txtMonthTo.Location = new System.Drawing.Point(926, 95);
            this.txtMonthTo.Name = "txtMonthTo";
            this.txtMonthTo.Size = new System.Drawing.Size(61, 22);
            this.txtMonthTo.TabIndex = 12;
            // 
            // txtMonthFrom
            // 
            this.txtMonthFrom.Location = new System.Drawing.Point(783, 95);
            this.txtMonthFrom.Name = "txtMonthFrom";
            this.txtMonthFrom.Size = new System.Drawing.Size(61, 22);
            this.txtMonthFrom.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(1032, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Năm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(867, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(703, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tháng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(598, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "Thống kê ";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(115, 157);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(368, 374);
            this.pieChart1.TabIndex = 16;
            this.pieChart1.Text = "pieChart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(193, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 29);
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
            this.dataTourOutStanding.Location = new System.Drawing.Point(583, 178);
            this.dataTourOutStanding.Name = "dataTourOutStanding";
            this.dataTourOutStanding.RowHeadersWidth = 51;
            this.dataTourOutStanding.RowTemplate.Height = 24;
            this.dataTourOutStanding.Size = new System.Drawing.Size(754, 334);
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
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(583, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tổng doanh thu:";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalPrice.Location = new System.Drawing.Point(779, 138);
            this.lbTotalPrice.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(200, 20);
            this.lbTotalPrice.TabIndex = 20;
            this.lbTotalPrice.Text = "Tổng doanh thu:";
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataTourOutStanding);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonthTo);
            this.Controls.Add(this.txtMonthFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartSale);
            this.Name = "Statistic";
            this.Size = new System.Drawing.Size(1386, 851);
            this.Load += new System.EventHandler(this.Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTourOutStanding)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataTourOutStanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentSale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalPrice;
    }
}
