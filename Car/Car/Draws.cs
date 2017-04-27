using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Car
{
    class Draws
    {
        public enum Direction
        {
            RIGHT,
            LEFT
        };

        //public GraphicsPath path1 = new GraphicsPath();

         public Direction direction = Direction.RIGHT;
         //Graphics g;
        public int  x = 100, y = 200, w = 150, h = 100;
 
        /*public Draws(int x, int y)
        {
            g.DrawLine(new Pen(Color.Black), x, y, x + 100, y);
            g.DrawLine(new Pen(Color.Black), x+100, y, x + 100, y+50);
            g.DrawLine(new Pen(Color.Black), x+100, y+50, x+150, y+50);
            g.DrawLine(new Pen(Color.Black), x+150, y+50, x + 150, y+100);
            g.DrawLine(new Pen(Color.Black), x+150, y+100, x -100, y+100);
            g.DrawLine(new Pen(Color.Black), x-100, y+100, x -100, y+50);
            g.DrawLine(new Pen(Color.Black), x-100, y+50, x, y+50);
            g.DrawLine(new Pen(Color.Black), x, y+50, x, y);

        }*/
        public void Move(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Black), x, y, w, h); 
        }
    }
}
