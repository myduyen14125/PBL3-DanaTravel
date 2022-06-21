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

namespace PBL3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bindingSource1.DataSource = new EmployeeDTO();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            EmployeeDTO employee = (EmployeeDTO)bindingSource1.DataSource;
            MessageBox.Show(employee.name + " || " + employee.email);
        }
    }
}
