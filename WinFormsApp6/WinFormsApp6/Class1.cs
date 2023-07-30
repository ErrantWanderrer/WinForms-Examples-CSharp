using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsApp6
{
    class Class1:Interface1
    {
        private int width, heith;
        public int X { set { width = value; } }
        public int Y { set { heith = value; } }
        public void Draw(Graphics e, int x, int y)
        {
            Pen blackPen = new Pen(Color.Black, 3);
            e.DrawRectangle(blackPen, x, y, width, heith);
            Point poin1 = new Point(x, y);
            Point poin2 = new Point(x + width, y+heith);
            e.DrawLine(blackPen, poin1, poin2);
        }
    }
}
