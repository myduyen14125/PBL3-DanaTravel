using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace PBL3.View.admin
{
    public partial class FormAddEditEmployee : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }

        private int employee_id;
        private Employee employee;

        public FormAddEditEmployee(int id = 0)
        {
            InitializeComponent();
            employee_id = id;
            employee = id == 0 ? new Employee() : EmployeeBLL.Instance.GetEmployeeById(id);
        }

        private void FormAddEditEmployee_Load(object sender, EventArgs e)
        {
            ShowForm();
            dataGridViewPer.DataSource = RoleBLL.Instance.GetDataTablePermission();
            dataGridViewPer.Columns["ID"].Visible = false;
            dataGridViewPer.Columns["STT"].Width = 50;
            dataGridViewPer.Columns["Permission"].Width = 175;
        }

        private void ShowForm()
        {
            SetComboboxDivision();
            SetComboboxPosition();
            SetComboboxEducation();
            SetListCheckBoxRole();
            bindingEmployee.DataSource = employee;

            if (employee_id != 0)
            {
                cbbPosition.SelectedIndex = cbbPosition.FindStringExact(employee.Position.name);
                cbbDivision.SelectedIndex = cbbDivision.FindStringExact(employee.Division.name);
                cbbEducation.SelectedIndex = cbbEducation.FindStringExact(employee.Education_degree.name);

                int size = checkListBoxRole.Items.Count;
                for (int i = 0; i < size; i++)
                {
                    foreach (Role r in employee.Account.Roles)
                    {
                        if (r.name == checkListBoxRole.Items[i].ToString())
                        {
                            checkListBoxRole.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
        }

        private void SetComboboxDivision()
        {
            cbbDivision.DisplayMember = "Text";
            cbbDivision.ValueMember = "Value";
            List<Division> divisions = EmployeeBLL.Instance.GetListDivision();
            List<object> items = new List<object>();
            foreach (Division d in divisions)
            {
                items.Add(new
                {
                    Text = d.name,
                    Value = d.id
                });
            }
            cbbDivision.DataSource = items;
        }

        private void SetComboboxPosition()
        {
            cbbPosition.DisplayMember = "Text";
            cbbPosition.ValueMember = "Value";
            List<Position> positions = EmployeeBLL.Instance.GetListPosition();
            List<object> items = new List<object>();
            foreach (Position p in positions)
            {
                items.Add(new
                {
                    Text = p.name,
                    Value = p.id
                });
            }
            cbbPosition.DataSource = items;
        }

        private void SetComboboxEducation()
        {
            cbbEducation.DisplayMember = "Text";
            cbbEducation.ValueMember = "Value";
            List<Education_degree> education_Degrees = EmployeeBLL.Instance.GetListEducation();
            List<object> items = new List<object>();
            foreach (Education_degree ed in education_Degrees)
            {
                items.Add(new
                {
                    Text = ed.name,
                    Value = ed.id
                });
            }
            cbbEducation.DataSource = items;
        }

        private void SetListCheckBoxRole()
        {
            checkListBoxRole.DataSource = RoleBLL.Instance.GetListRoleName();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            txtAccount.Text = email;
            txtPassword.Text = email;
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddRole f = new FormAddRole();
            f.d = new FormAddRole.Mydel(ShowForm);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFormSave())   return;
            
            // Email cũ khác email mới thì đăng ký tài khoản cho email mới + khoá tài khoản email cũ
            if (txtEmail.Text != employee.email)
            {
                AccountBLL.Instance.ChangeStatusAccount(employee.email, false);
                RegisterAccount();
            }
            if(employee_id == 0) RegisterAccount();

            Account account = AccountBLL.Instance.GetAccountByUsername(txtEmail.Text);
            Employee epl = (Employee)bindingEmployee.DataSource;
            epl.position_id = (cbbPosition.SelectedItem as dynamic).Value;
            epl.division_id = (cbbDivision.SelectedItem as dynamic).Value;
            epl.education_degree_id = (cbbEducation.SelectedItem as dynamic).Value;
            epl.account_id = account.id;
            EmployeeBLL.Instance.Save(epl);

            if (employee_id == 0) MessageBox.Show("Addition successful");
            else MessageBox.Show("Edit successful");
            d();
            this.Hide();
        }

        private void RegisterAccount()
        {
            List<Role> roles = new List<Role>();
            foreach (var r in checkListBoxRole.CheckedItems)
            {
                roles.Add(RoleBLL.Instance.GetRoleByName(r.ToString()));
            }
            Account ac = new Account
            {
                username = txtEmail.Text,
                password = HashPassword.GetHash(txtEmail.Text),
                status = true,
                Roles = roles
            };
            AccountBLL.Instance.RegisterAccount(ac);
        }

        private void checkListBoxRole_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                List<string> roleNames = new List<string>();
                foreach (var r in checkListBoxRole.CheckedItems)
                {
                    roleNames.Add(r.ToString());
                }
                dataGridViewPer.DataSource = RoleBLL.Instance.GetDataTablePermission(RoleBLL.Instance.GetListPermission(roleNames));
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            d();
            this.Hide();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            Image image = ImageHelper.GetImage();
            if (image == null) return;
            picturebox.Image = image;
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

            if (checkListBoxRole.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please choose role for employee");
                return false;
            }
            return true;
        }
    }
}
