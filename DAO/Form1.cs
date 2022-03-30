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

namespace DAO
{
    public partial class Form1 : Form
    {
        //private LoginDAO login = new LoginDAO();
        private EntityManager db = new EntityManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from a in db.Accounts
                                         from r in db.Roles
                                         from p in db.Permissions
                                         where a.username == "daitoan2000@gmail.com" && a.password == "123456"
                                         select new { r.role_id, r.role_name, p.per_name }).ToList();
        }
    }
}
