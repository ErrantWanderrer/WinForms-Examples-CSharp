using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    public class Vector
    {
        private int x, y;
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public Vector (int xx, int yy)
        {
            x = xx;
            y = yy;
        }
    }
}
