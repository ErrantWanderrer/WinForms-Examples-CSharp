using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsApp6
{
    class Class2:Interface1
    {
        private int width, heith;
        public int X { set { width = value; } }
        public int Y { set { heith = value; } }
        public void Draw(Graphics e, int x, int y)
        {
            //Pen blackPen = new Pen(Color.Black, 3);
            Pen redPen = new Pen(Color.Red, 3);
            Point point1 = new Point(x, y + heith);
            Point point2 = new Point(x + width, y + heith);
            Point point3 = new Point(x + width / 2, y);
            //e.DrawRectangle(blackPen, x, y, width, heith);
            e.DrawLine(redPen, point1, point2);
            e.DrawLine(redPen, point1, point3);
            e.DrawLine(redPen, point3, point2);
        }
    }
}
