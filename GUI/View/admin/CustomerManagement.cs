using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3.View.admin
{
    public partial class CustomerManagement : UserControl
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }
        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                SetComboboxCustomerType();
                ShowDataCustomer();
            }
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void SetComboboxCustomerType()
        {
            cbbCustomerType.DisplayMember = "Text";
            cbbCustomerType.ValueMember = "Value";
            List<CustomerType> customerTypes = CustomerBLL.Instance.GetListCustomerType();
            List<Object> items = new List<object>();
            items.Add(new
            {
                Text = "All",
                Value = 0
            });
            foreach (CustomerType ct in customerTypes)
            {
                items.Add(new
                {
                    Text = ct.name,
                    Value = ct.id
                });
            }
            cbbCustomerType.DataSource = items;
            cbbCustomerType.SelectedIndex = 0;
        }

        private void ShowDataCustomer()
        {
            int typeId = (cbbCustomerType.SelectedItem as dynamic).Value;
            string searchKey = txtSearch.Text;
            dataGridViewCustomer.DataSource = CustomerBLL.Instance.GetDataTableCustomer(CustomerBLL.Instance.GetListCustomers(typeId, searchKey));
            txtTotal.Text = (dataGridViewCustomer.Rows.Count - 1).ToString();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void cbbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDataCustomer();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDataCustomer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDataCustomer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditCustomer f = new FormAddEditCustomer();
            f.d = new FormAddEditCustomer.Mydel(ShowDataCustomer);
            f.Show();
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewCustomer.CurrentRow.Cells[0].Value.ToString());
            FormAddEditCustomer f = new FormAddEditCustomer(id);
            f.d = new FormAddEditCustomer.Mydel(ShowDataCustomer);
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
                CustomerBLL.Instance.Delete(list);
                ShowDataCustomer();
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
