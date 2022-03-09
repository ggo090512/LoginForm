using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = textboxusername.Text;
            string pass = textbotmatkhau.Text;
            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("Success");
            }
        }
    }
}
