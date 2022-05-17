using BUS;
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

        private int employeeId;
        private EmployeeDTO employee;

        public FormAddEditEmployee(int id = 0)
        {
            InitializeComponent();
            employeeId = id;
            if(id != 0) employee = EmployeeBUS.Instance.GetEmployeeDTOById(employeeId);
        }

        private void FormAddEditEmployee_Load(object sender, EventArgs e)
        {
            SetComboboxDivision();
            SetComboboxPosition();
            SetComboboxEducation();
            ShowForm();
            dataGridViewPer.DataSource = RoleBUS.Instance.GetDataTablePermission();

            dataGridViewPer.Columns["ID"].Visible = false;
            dataGridViewPer.Columns["STT"].Width = 50;
            dataGridViewPer.Columns["Permission"].Width = 175;
        }
        
        private void ShowForm()
        {
            SetListCheckBoxRole();
            
            // Edit => Render data into form
            if(employeeId != 0)
            {
                txtName.Text = employee.name;
                dateTimePicker1.Value = employee.birthday;
                radioMale.Checked = employee.gender;
                radioFemale.Checked = !employee.gender;
                txtCCCD.Text = employee.idCard;
                txtPhone.Text = employee.phone;
                txtEmail.Text = employee.email;
                txtPassword.Text = "";
                txtAddress.Text = employee.address;
                txtSalary.Text = employee.salary.ToString(); 
                cbbPosition.SelectedIndex = cbbPosition.FindStringExact(employee.position_name);
                cbbDivision.SelectedIndex = cbbDivision.FindStringExact(employee.division_name); 
                cbbEducation.SelectedIndex = cbbEducation.FindStringExact(employee.education_degree_name);
                txtAccount.Text = employee.email;
               if(employee.image != null)
                    picturebox.Image = Image.FromStream(new MemoryStream(employee.image));
                int size = checkListBoxRole.Items.Count;
                for (int i = 0; i < size; i++)
                {
                    foreach (Role r in employee.roles)
                    {
                        if (r.name == checkListBoxRole.Items[i].ToString())
                        {
                            checkListBoxRole.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
            this.Show();
        }

        private void SetComboboxDivision()
        {
            cbbDivision.DisplayMember = "Text";
            cbbDivision.ValueMember = "Value";
            List<Division> divisions = EmployeeBUS.Instance.GetListDivision();
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
            List<Position> positions = EmployeeBUS.Instance.GetListPosition();
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
            List<Education_degree> education_Degrees = EmployeeBUS.Instance.GetListEducation();
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
            checkListBoxRole.DataSource = RoleBUS.Instance.GetListRoleName();
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

        /*
            - Add account 
            - if employee == null => Add else Update
              if Add then set id employee = 0
         */
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateFormSave())
            {
                return;
            }
            Account ac;
            string email = txtEmail.Text;
            // Add account if add employee or change email (because username === email)
            if (employeeId == 0 || email != employee.email)
            {
                List<Role> roles = new List<Role>();
                foreach (var r in checkListBoxRole.CheckedItems)
                {
                    roles.Add(RoleBUS.Instance.GetRoleByName(r.ToString()));
                }
                ac = new Account
                {
                    username = email,
                    password = HashPassword.GetHash(email),
                    status = true,
                    Roles = roles
                };
                AccountBUS.Instance.RegisterAccount(ac);
                SendEmailHelper send = new SendEmailHelper();
                send.SendNotifyEmail(email, "<h1>DanaTravel send your account for login Danatravel Application.</h1> " +
                    "<h3> Your account: " + email + "</h3>"
                    + "<h3>Password: " + email + "</h3>"
                    + "<h3>Please login to change your password</h3>");
            }
            
            ac = AccountBUS.Instance.GetAccountByUsername(email);

            MemoryStream stream = new MemoryStream();
            Image image = picturebox.Image;
            image.Save(stream, image.RawFormat);

            // Add employee
            Employee epl = new Employee
            {
                id = employeeId,
                name = txtName.Text,
                birthday = dateTimePicker1.Value,
                gender = radioMale.Checked ? true : false,
                idCard = txtCCCD.Text,
                phone = txtPhone.Text,
                email = txtEmail.Text,
                address = txtAddress.Text,
                salary = Convert.ToDouble(txtSalary.Text),
                position_id = (cbbPosition.SelectedItem as dynamic).Value,
                division_id = (cbbDivision.SelectedItem as dynamic).Value,
                education_degree_id = (cbbEducation.SelectedItem as dynamic).Value,
                account_id = ac.id,
                image = stream.ToArray()
            };
            EmployeeBUS.Instance.Save(epl);
            if (employeeId != 0 && email != employee.email)
            {
                AccountBUS.Instance.DeleteAccount(employee.account_name);
            }
            if(employeeId == 0) MessageBox.Show("Addition successful");
            else MessageBox.Show("Edit successful");
            d();
            this.Hide();
        }

        private bool ValidateFormSave()
        {
            // Validate 
            Validate validate = new Validate();
            if(txtName.Text == "")
            {
                MessageBox.Show("Please enter name");
                txtName.Focus();
                return false;
            }

            if(!radioFemale.Checked && !radioMale.Checked)
            {
                MessageBox.Show("Please choose gender");
                return false;
            }

            if(!validate.ValidateIdCard(txtCCCD.Text))
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

        private void checkListBoxRole_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                List<string> roleNames = new List<string>();
                foreach (var r in checkListBoxRole.CheckedItems)
                {
                    roleNames.Add(r.ToString());
                }
                dataGridViewPer.DataSource = RoleBUS.Instance.GetDataTablePermission(RoleBUS.Instance.GetListPermission(roleNames));
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            d();
            this.Hide();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string file = ofd.FileName;
            if (string.IsNullOrEmpty(file))
            {
                return;
            }
            picturebox.Image = Image.FromFile(file);
        }
    }
}
