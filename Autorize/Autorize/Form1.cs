using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Autorize
{
    public partial class Form1 : Form
    {
        public string s1 = "admin";
        public string s2 = "password123!";
        public int log, pas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(log>0 && pas>0)
                MessageBox.Show("Success autorization");
            else MessageBox.Show("Unautorized user");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == s1)
            {
                log = 1;
                //button1.Enabled = true;
            }
            else log = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == s1 && textBox1.ToString().Length >= 8)
            {
                pas = 1;
                button1.Enabled = true;
            }
            else pas = 0;
        }
    }
}
