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

namespace PBL3.View.admin
{
    public partial class FormAddRole : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }

        public FormAddRole()
        {
            InitializeComponent();
        }

        private void FormAddRole_Load(object sender, EventArgs e)
        {
            dataGridViewPermission.DataSource = RoleBLL.Instance.GetDataTablePermission();
            dataGridViewPermission.Columns["ID"].Visible = false;
            dataGridViewPermission.Columns["Permission"].Width = 290;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            d();
            this.Hide();
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            string roleName = txtRole.Text;
            List<Permission> permissions = new List<Permission>();
            foreach(DataGridViewRow r in dataGridViewPermission.Rows)
            {
                if (r.Cells["ID"].Value == null)
                {
                    break;
                } 
                else if (Convert.ToBoolean(r.Cells["Licensing"].Value.ToString()))
                {
                    permissions.Add(RoleBLL.Instance.GetPermissionById(Convert.ToInt32(r.Cells["ID"].Value.ToString())));
                }
            }
            Role role = new Role
            {
                name = roleName,
                Permissions = permissions
            };
            RoleBLL.Instance.Add(role);
            d();
            this.Hide();
        }

    }
}
