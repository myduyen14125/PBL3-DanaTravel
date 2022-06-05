using BUS;
using DTO;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.statistics
{
    public partial class Statistic : UserControl
    {
        private string[] months = { "Jan", "Feb", "Mar", "April", "May", "June", "July", "August", "Sep", "Oct", "Nov", "Dec" };
        public Statistic()
        {
            InitializeComponent();
        }
        private void Statistic_Load(object sender, EventArgs e)
        {
            if(!this.DesignMode)
            {
                DrawChartSale(1, 12, 2022);
                DrawChartTourOutStanding(1, 12, 2022);
            }
        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            int monthFrom = Convert.ToInt32(txtMonthFrom.Text);
            int monthTo = Convert.ToInt32(txtMonthTo.Text);
            int year = Convert.ToInt32(txtYear.Text);
            DrawChartSale(monthFrom, monthTo, year);
            DrawChartTourOutStanding(monthFrom, monthTo, year);
        }

        private void DrawChartSale(int monthFrom, int monthTo, int year)
        {
            chartSale.Series["chartSale"].Points.Clear();
            List<Revenue> revenues = StatisticBUS.Instance.GetRevenues(monthFrom, monthTo, year);
            int i = 0;
            foreach (Revenue revenue in revenues)
            {
                chartSale.Series["chartSale"].Points.Add(revenue.total);
                chartSale.Series["chartSale"].Points[i].Label = revenue.total.ToString("###,###,###,###");
                chartSale.Series["chartSale"].Points[i].AxisLabel = months[Convert.ToInt32(revenue.name) - 1];
                i++;
            }
        }
        private void DrawChartTourOutStanding(int monthFrom, int monthTo, int year)
        {
            List<Revenue> revenues = StatisticBUS.Instance.GetRevenuesTourOutStanding(monthFrom, monthTo, year);
            if (revenues.Count == 0) return;
            dataTourOutStanding.Rows.Clear();
            double total_price = revenues.Sum(r => r.total);
            lbTotalPrice.Text = total_price.ToString("###,###,###,###") + " VNĐ";

            SeriesCollection series = new SeriesCollection();
            double total_res = total_price;
            for (int i = 0; i <= 3; i++)
            {
                if (i >= revenues.Count) break;
                double percent = Convert.ToDouble((revenues[i].total * 100.0 / total_price).ToString("##.##"));
                total_res = total_res - revenues[i].total;
                series.Add(new PieSeries()
                {
                    Title = revenues[i].name,
                    Values = new ChartValues<double> { percent },
                    DataLabels = true,
                });
                dataTourOutStanding.Rows.Add(revenues[i].name, revenues[i].total.ToString("###,###,###,###"), percent);
            }
            double percent_res = Convert.ToDouble((total_res * 100.0 / total_price).ToString("###.###"));
            if (percent_res >= 0.001)
            {
                series.Add(new PieSeries()
                {
                    Title = "Tour khác",
                    Values = new ChartValues<double> { percent_res },
                    DataLabels = true,
                });
            }
            dataTourOutStanding.Rows.Add("Các tour còn lại", total_res.ToString("###,###,###,###"), percent_res);
            pieChart1.Series = series;
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
    }
}
