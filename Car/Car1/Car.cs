using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Car
{
    class Car
    {
        public int x = 10, y = 10, w = 100, h = 100;
        public enum Direction
        {
            LEFT,
            RIGHT
        }
        public Direction direction = Direction.RIGHT;
        

        public void Up(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Red), x, y, w, h);

        }
    }
}
