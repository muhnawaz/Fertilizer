using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fertilizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Please Enter Email", "Validation");
                textBoxEmail.Focus();
                return;

            }
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Validation");
                textBoxPassword.Focus();
                return;

            }
        }
    }
}
