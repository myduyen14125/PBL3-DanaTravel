using DTO;
using BUS;
using DAO;
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
        EntityManager db = EntityManager.Instance;
        public Statistic()
        {
            InitializeComponent();
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY("Jan", 100);
            chart1.Series[1].Points.AddXY("Jan", 200);

            chart1.Series[0].Points.AddXY("Feb", 150);
            chart1.Series[1].Points.AddXY("Feb", 130);

            dataGridView1.DataSource = EntityManager.Instance.Statistics.ToList(); 
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "month";
            chart1.Series[0].YValueMembers = "totalTour";

            chart1.Series[1].XValueMember = "month";
            chart1.Series[1].YValueMembers = "totalMoney";


            chart1.DataSource = EntityManager.Instance.Statistics.ToList();
            chart1.DataBind();
        }
    }
}
