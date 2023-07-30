using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            t = point;
            label1.Text = "Активный объект: точка";
        }
        Point point = new Point();
        RegularPentagon pent = new RegularPentagon();
        RightTriangle triang = new RightTriangle();
        Rectangle rect = new Rectangle();
        Point t;

        public class Point
        {
            public float Square()
            {
                return 0;
            }

            public virtual float SquareVirt()
            {
                return 0;
            }
        }

        public class RegularPentagon : Point
        {
            private float side;
            public RegularPentagon()
            {
                side = 3;
            }

            public float Square()
            {
                float S = (float)(5 / 4 * side * side * (1 / Math.Tan(Math.PI / 5)));
                return S;
            }

            public override float SquareVirt()
            {
                float S = (float)(5 / 4 * side * side * (1 / Math.Tan(Math.PI / 5)));
                return S;
            }

            public float Perimeter()
            {
                float P = side * 5;
                return P;
            }
        }

        public class RightTriangle : Point
        {
            private float firstCathet;
            private float secondCathet;
            public RightTriangle()
            {
                firstCathet = 3;
                secondCathet = 4;
            }
            public float Square()
            {
                float S = 0.5f * firstCathet * secondCathet;
                return S;
            }

            public override float SquareVirt()
            {
                float S = 0.5f * firstCathet * secondCathet;
                return S;
            }

            public float Perimeter()
            {
                float P = (float)(firstCathet + secondCathet + Math.Sqrt(Math.Pow(firstCathet, 2) + Math.Pow(secondCathet, 2)));
                return P;
            }
        }

        public class Rectangle : Point
        {
            private float firstSide;
            private float secondSide;
            public Rectangle()
            {
                firstSide = 5;
                secondSide = 6;
            }
            public float Square()
            {
                float S = firstSide * secondSide;
                return S;
            }

            public override float SquareVirt()
            {
                float S = firstSide * secondSide;
                return S;
            }
            public float Perimeter()
            {
                float P = firstSide * 2 + secondSide * 2;
                return P;
            }
            public float Diag()
            {
                float D = (float)(Math.Sqrt(Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2)));
                return D;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = point;
            label1.Text = "Активный объект: точка";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t = pent;
            label1.Text = "Активный объект: правильный пятиугольник";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t = triang;
            label1.Text = "Активный объект: прямоугольный треугольник";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t = rect;
            label1.Text = "Активный объект: прямоугольник";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (t is RegularPentagon)
            {
                label2.Text = ((RegularPentagon)t).Square().ToString();
            }
            else if (t is RightTriangle)
            {
                label2.Text = ((RightTriangle)t).Square().ToString();
            }
            else if (t is Rectangle)
            {
                label2.Text = ((Rectangle)t).Square().ToString();
            }
            else if (t is Point)
            {
                label2.Text = t.Square().ToString();
            }
            else
                label2.Text = "Метод Square() для активного объекта не определен";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = t.SquareVirt().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (t is RegularPentagon)
            {
                label2.Text = ((RegularPentagon)t).Perimeter().ToString();
            }
            else if (t is RightTriangle)
            {
                label2.Text = ((RightTriangle)t).Perimeter().ToString();
            }
            else if (t is Rectangle)
            {
                label2.Text = ((Rectangle)t).Perimeter().ToString();
            }
            else
                label2.Text = "Метод Perimeter() для активного объекта не определен";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (t is Rectangle)
            {
                label2.Text = ((Rectangle)t).Diag().ToString();
            }
            else
                label2.Text = "Метод Diag() для активного объекта не определен";
        }
    }
}
