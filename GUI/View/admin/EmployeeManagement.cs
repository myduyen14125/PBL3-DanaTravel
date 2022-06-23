using BLL;
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
        public EmployeeManagement()
        {
            InitializeComponent();
            cbbSortBy.SelectedIndex = 0;
            cbbSortDir.SelectedIndex = 0;
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
        }

        private void SetComboboxDivision()
        {
            cbbDivision.DisplayMember = "Text";
            cbbDivision.ValueMember = "Value";
            List<Division> divisions = EmployeeBLL.Instance.GetListDivision();
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
            string sortDir = cbbSortDir.SelectedItem.ToString();
            string sortBy =  cbbSortBy.SelectedItem.ToString();
            
            dataGridViewEmployee.DataSource = EmployeeBLL.Instance.GetDataTableEmployee(EmployeeBLL.Instance.GetListEmployee(divisionId, searchKey, sortBy, sortDir));
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
                EmployeeBLL.Instance.Delete(list);
                ShowDataEmployee();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ShowDataEmployee();
        }
    }
}
