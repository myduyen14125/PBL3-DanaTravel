using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.viewHtml
{
    public partial class TextInsertForm : Form
    {
        private bool _accepted = false;

        public TextInsertForm(string text)
        {
            InitializeComponent();
            textBox1.Text = text;
        }

        public string HTML
        {
            get { return textBox1.Text; }
        }

        public bool Accepted
        {
            get { return _accepted; }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _accepted = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
