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
                btnLock.Enabled = false;
                btnUnlock.Enabled = false;
                ShowDataAccount();
            }
        }
        private void ShowDataAccount()
        {
            dataAccount.DataSource = AccountBUS.Instance.GetDataTableEmployeeAccounts(txtSearch.Text);
            dataAccount.Columns["ID"].Visible = false;
            txtTotal.Text = (dataAccount.Rows.Count - 1).ToString();
        }
        private void dataAccount_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnLock.Enabled = true;
            btnUnlock.Enabled = true;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to lock account " + dataAccount.CurrentRow.Cells[4].Value, "Notify", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (Convert.ToBoolean(dataAccount.CurrentRow.Cells[5].Value))
                {
                    AccountBUS.Instance.ChangeStatusAccount(Convert.ToInt32(dataAccount.CurrentRow.Cells[1].Value), false);
                    dataAccount.CurrentRow.Cells[5].Value = false;
                }
                MessageBox.Show("Account " + dataAccount.CurrentRow.Cells[4].Value + " has been lock");
            } 
            btnLock.Enabled = false;
            btnUnlock.Enabled = false;

        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to lock account " + dataAccount.CurrentRow.Cells[4].Value, "Notify", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (!Convert.ToBoolean(dataAccount.CurrentRow.Cells[5].Value))
                {
                    AccountBUS.Instance.ChangeStatusAccount(Convert.ToInt32(dataAccount.CurrentRow.Cells[1].Value), true);
                    dataAccount.CurrentRow.Cells[5].Value = true;
                }
                MessageBox.Show("Account " + dataAccount.CurrentRow.Cells[4].Value + " has been unlock");
            }
            btnLock.Enabled = false;
            btnUnlock.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDataAccount();
        }
    }
}
