using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace PBL3
{
    public partial class FormAddEditCustomer : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }

        private int customerID;
        private Customer customer;
        public FormAddEditCustomer(int id = 0)
        {
            InitializeComponent();
            customerID = id;
            if (id != 0) customer = CustomerBLL.Instance.GetCustomerDTOById(customerID);
            else customer = new Customer();
        }

        private void FormAddEditCustomer_Load(object sender, EventArgs e)
        {
            SetComboboxCustomerType();
            bindingCustomer.DataSource = customer;

            if(customer.gender != null)
            {
                radioMale.Checked = Convert.ToBoolean(customer.gender);
                radioFemale.Checked = Convert.ToBoolean(!customer.gender);
            }
        }

        private void SetComboboxCustomerType()
        {
            cbbCustomerType.DisplayMember = "Text";
            cbbCustomerType.ValueMember = "Value";
            List<CustomerType> customerTypes = CustomerBLL.Instance.GetListCustomerType();
            List<Object> items = new List<object>();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            d();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFormSave())    return;
            
            Customer customerDTO = (Customer)bindingCustomer.DataSource;
            customer.customer_type_id = (cbbCustomerType.SelectedItem as dynamic).Value;
            if (radioMale.Checked) customerDTO.gender = true;
            if (radioFemale.Checked) customerDTO.gender = false;
            
            CustomerBLL.Instance.Save(customer);

            if(customerID == 0)     
                MessageBox.Show("Addition customer successful");
            else 
                MessageBox.Show("Edition customer successful");
            d();
            this.Hide();
        }

        private bool ValidateFormSave()
        {
            // Validate 
            Validate validate = new Validate();
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter name");
                txtName.Focus();
                return false;
            }

            if (!validate.ValidateIdCard(txtCCCD.Text))
            {
                MessageBox.Show("Id Card invalid");
                txtCCCD.Focus();
                return false;
            }

            if (!validate.ValidatePhone(txtPhone.Text))
            {
                MessageBox.Show("Phone invalid");
                txtPhone.Focus();
                return false;
            }

            if (!validate.ValidateEmail(txtEmail.Text))
            {
                MessageBox.Show("Email invalid");
                txtEmail.Focus();
                return false;
            }

            return true;
        }
    }
}
