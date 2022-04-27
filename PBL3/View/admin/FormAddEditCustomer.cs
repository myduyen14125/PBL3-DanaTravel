using BUS;
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
        private CustomerDTO customer;
        public FormAddEditCustomer(int id = 0)
        {
            InitializeComponent();
            customerID = id;
            if (id != 0) customer = CustomerBUS.Instance.GetCustomerDTOById(customerID);
        }

        private void FormAddEditCustomer_Load(object sender, EventArgs e)
        {
            SetComboboxCustomerType();
            ShowForm();

        }

        private void SetComboboxCustomerType()
        {
            cbbCustomerType.DisplayMember = "Text";
            cbbCustomerType.ValueMember = "Value";
            List<CustomerType> customerTypes = CustomerBUS.Instance.GetListCustomerType();
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

        private void ShowForm()
        {
            // Edit => Render data into form
            if (customerID != 0)
            {
                txtName.Text = customer.name;
                dateTimePicker1.Value = customer.birthday;
                radioMale.Checked = customer.gender;
                radioFemale.Checked = !customer.gender;
                txtCCCD.Text = customer.idCard;
                txtPhone.Text = customer.phone;
                txtEmail.Text = customer.email;
                txtAddress.Text = customer.address;
            }
            this.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            d();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFormSave())
            {
                return;
            }

            string email = txtEmail.Text;

            // Add customer
            Customer cus = new Customer
            {
                id = customerID,
                name = txtName.Text,
                birthday = dateTimePicker1.Value,
                gender = radioMale.Checked ? true : false,
                idCard = txtCCCD.Text,
                phone = txtPhone.Text,
                email = txtEmail.Text,
                address = txtAddress.Text,
                customer_type_id = (cbbCustomerType.SelectedItem as dynamic).Value
            };
            CustomerBUS.Instance.Save(cus);

            MessageBox.Show("Addition customer successful");
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

            if (!radioFemale.Checked && !radioMale.Checked)
            {
                MessageBox.Show("Please choose gender");
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
