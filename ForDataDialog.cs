using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreevIEW
{
    public partial class ForDataDialog : Form
    {
        public ForDataDialog()
        {
            InitializeComponent();
        }

        public ForDataDialog(string title, string designation)
        {
            InitializeComponent();
            this.label1.Text = designation;
        }

        public string data;


        private void btOk_Click(object sender, EventArgs e)
        {
            this.data = this.textBox1.Text;
            this.Close();
        }
    }
}
