using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsApp6
{
    interface Interface1
    {
        int X { set; }
        int Y { set; }
        void Draw(Graphics e, int x, int y);
    }
}
