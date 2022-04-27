using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class TourManagement : UserControl
    {
        public TourManagement()
        {
            InitializeComponent();
        }
        private void TourManagement_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                ShowDataTour();
            }
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void ShowDataTour()
        {
            string searchKey = txtSearch.Text;
            dataGridViewCustomer.DataSource = TourBUS.Instance.GetDataTableTour(TourBUS.Instance.GetListTours(searchKey));
            txtTotal.Text = (dataGridViewCustomer.Rows.Count - 1).ToString();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDataTour();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDataTour();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditTour f = new FormAddEditTour();
            f.myDel = new FormAddEditTour.MyDel(ShowDataTour);
            f.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewCustomer.CurrentRow.Cells[0].Value.ToString());
            FormAddEditTour f = new FormAddEditTour(id);
            f.myDel = new FormAddEditTour.MyDel(ShowDataTour);
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want delete?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                List<int> list = new List<int>();
                foreach (DataGridViewRow row in dataGridViewCustomer.SelectedRows)
                {
                    list.Add(Convert.ToInt32(row.Cells["ID"].Value));
                }
                TourBUS.Instance.Delete(list);
                ShowDataTour();
            }
        }

        private void dataGridViewCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewCustomer.SelectedRows.Count == 1)
            {
                btnEdit.Enabled = true;
            }
            else btnEdit.Enabled = false;

            if (dataGridViewCustomer.SelectedRows.Count >= 1)
            {
                btnDelete.Enabled = true;
            }
            else btnDelete.Enabled = false;
        }
    }
}
