using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {

        Draws d = new Draws();
        public int x1 = 100, y1 = 200;

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            d.Move(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (d.direction == Draws.Direction.RIGHT)
            {
                d.x += 5;
            }
            if (d.direction == Draws.Direction.LEFT)
            {
                d.x -= 5;
            }
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                d.direction = Draws.Direction.RIGHT;
            }
            if (e.KeyCode == Keys.D)
            {
                d.direction = Draws.Direction.LEFT;
            }
        }

    }
}
