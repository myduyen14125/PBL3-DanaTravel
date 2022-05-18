using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class AccountEmployee : UserControl
    {
        public AccountEmployee()
        {
            InitializeComponent();
        }

        private void AccountEmployee_Load(object sender, EventArgs e)
        {
            if(!this.DesignMode)
            {
                dataAccount.DataSource = AccountBUS.Instance.GetDataTableEmployeeAccounts();
                btnLock.Enabled = false;
                btnUnlock.Enabled = false;
            }
        }

        private void dataAccount_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnLock.Enabled = true;
            btnUnlock.Enabled = true;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            // Lock: khóa
            if(!Convert.ToBoolean(dataAccount.CurrentRow.Cells[4].Value))
            {
                
            }
            MessageBox.Show("Account " + dataAccount.CurrentRow.Cells[3].Value + " has been lock");
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dataAccount.CurrentRow.Cells[4].Value))
            {
                
            }
            MessageBox.Show("Account " + dataAccount.CurrentRow.Cells[3].Value + " has been unlock");
        }
    }
}
