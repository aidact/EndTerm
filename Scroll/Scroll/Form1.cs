using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Font = new Font("Arial", 14, FontStyle.Bold);
            label2.Font = new Font("Arial", trackBar1.Value + 10, FontStyle.Bold);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
