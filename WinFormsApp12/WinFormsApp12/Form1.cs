using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp12
{

    public partial class Form1 : Form
    {
        private const int x = 960;
        private const int y = 500;
        private float _r = 5f;
        private float angle = 1f;
        public static int pointCount = 1000;
        private Point[] points = new Point[pointCount];
        Graphics coordLines;
        Graphics function;
        Graphics figure;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            panel1.BackColor = Color.FromArgb(0, Color.White);
            //panel2.BackColor = Color.FromArgb(0, Color.White);
            coordLines = panel1.CreateGraphics();
            function = panel1.CreateGraphics();
            figure = panel1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void DrawCoordLines()
        {
            Pen pen = new Pen(Color.Red, 3);
            Point point1 = new Point(960, 0);
            Point point2 = new Point(960, 1000);
            coordLines.DrawLine(pen, point1, point2);
            Point point3 = new Point(50, 500);
            Point point4 = new Point(1850, 500);
            coordLines.DrawLine(pen, point3, point4);
        }
        public void DrawFunction()
        {
            for (int i = 0; i <= pointCount-1; i++)
            {
                points[i] = new Point((int)(x-(_r * angle * Math.Cos(angle))), (int)((_r * angle * Math.Sin(angle))+y));
                angle = angle + 0.1f;
                Debug.WriteLine(points[i]);
            }
            Pen pen = new Pen(Color.Indigo, 1.5f);
            function.DrawCurve(pen, points);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawCoordLines();
            DrawFunction();
        }

        public void DrawFigure()
        {
           
            Pen pen = new Pen(Color.DarkCyan, 2f);
            Brush br = new SolidBrush(Color.DarkCyan);
            Brush br2 = new SolidBrush(Color.White);
            Pen pen2 = new Pen(Color.Indigo, 1.5f);
            Pen white = new Pen(Color.White, 2f);
            for (int i = 0; i <= pointCount-1; i++)
            {
                if (i > 1)
                    figure.FillEllipse(br2, points[i - 1].X, points[i - 1].Y, 50, 50);
                figure.FillEllipse(br, points[i].X, points[i].Y, 50, 50);
                DrawCoordLines();
                function.DrawCurve(pen2, points);
                System.Threading.Thread.Sleep(1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrawFigure();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
