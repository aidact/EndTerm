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
         Car car = new Car();
      
     
        
        public Form1()
        {
            InitializeComponent();
      
        }
        
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           car.Up(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (car.direction == Car.Direction.RIGHT)
            {
                car.x += 10;
                
            }
            if (car.direction == Car.Direction.LEFT)
            {
                car.x -= 10;

            }
            Refresh();
        }
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                car.direction = Car.Direction.RIGHT;
            }
            if (e.KeyCode == Keys.A)
            {
                car.direction = Car.Direction.LEFT;
            }
        }
       

       
    }
}
