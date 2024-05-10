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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Please Enter Name","Validation");
                textBoxName.Focus();
                return;
               
            }
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
            Entities db = new Entities();

            var customer = new Customer();

            customer.Name = textBoxName.Text;
            customer.Email = textBoxEmail.Text;
            customer.Password = textBoxPassword.Text;

            db.Customers.Add(customer);
            Cursor.Current = Cursors.Default;
            db.SaveChanges();
            MessageBox.Show("Registered Succeccfully", "Success");
            this.Hide();
            var login = new Form1();
            login.ShowDialog();
        }
    }
}
