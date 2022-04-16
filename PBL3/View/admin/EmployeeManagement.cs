using BUS;
using PBL3.View.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using DTO;
using System.Runtime.InteropServices;

namespace PBL3
{
    public partial class EmployeeManagement : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEclipse,
                int nHeightEclipse
            );
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                SetComboboxDivision();
                ShowDataEmployee();
            }
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnShow.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnShow.Width, btnShow.Height, 30, 30));
            btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 30, 30));
            btnEdit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEdit.Width, btnEdit.Height, 30, 30));
            btnDelete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDelete.Width, btnDelete.Height, 30, 30));
            btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 30, 30));
        }

        private void SetComboboxDivision()
        {
            cbbDivision.DisplayMember = "Text";
            cbbDivision.ValueMember = "Value";
            List<Division> divisions = EmployeeBUS.Instance.GetListDivision();
            List<Object> items = new List<object>();
            items.Add(new
            {
                Text = "All",
                Value = 0
            }) ;
            foreach (Division d in divisions)
            {
                items.Add(new
                {
                    Text = d.name,
                    Value = d.id
                });
            }
            cbbDivision.DataSource = items;
            cbbDivision.SelectedIndex = 0;
        }

        private void ShowDataEmployee()
        {
            int divisionId = (cbbDivision.SelectedItem as dynamic).Value;

            string searchKey = txtSearch.Text;

            dataGridViewEmployee.DataSource = EmployeeBUS.Instance.GetDataTableEmployee(EmployeeBUS.Instance.GetListEmployee(divisionId, searchKey));
            txtTotal.Text = (dataGridViewEmployee.Rows.Count - 1).ToString();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDataEmployee();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDataEmployee();
        }

        private void cbbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDataEmployee();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditEmployee f = new FormAddEditEmployee();
            f.d = new FormAddEditEmployee.Mydel(ShowDataEmployee);
            f.Show();
        }

        private void dataGridViewEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count == 1)
            {
                btnEdit.Enabled = true;
            }
            else btnEdit.Enabled = false;

            if (dataGridViewEmployee.SelectedRows.Count >= 1)
            {
                btnDelete.Enabled = true;
            }
            else btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString());
            FormAddEditEmployee f = new FormAddEditEmployee(id);
            f.d = new FormAddEditEmployee.Mydel(ShowDataEmployee);
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want delete?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                List<int> list = new List<int>();
                foreach (DataGridViewRow row in dataGridViewEmployee.SelectedRows)
                {
                    list.Add(Convert.ToInt32(row.Cells["ID"].Value));
                }
                EmployeeBUS.Instance.Delete(list);
                ShowDataEmployee();
            }
        }
    }
}
