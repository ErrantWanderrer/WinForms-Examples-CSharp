using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        Interface1 Figure;
        Graphics fig;
        Dialog diag = new Dialog();
        public Form1()
        {
            InitializeComponent();
            fig = Graphics.FromHwnd(Handle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figure = new Class1();
            diag.ShowDialog();
            Figure.X = diag.X;
            Figure.Y = diag.Y;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Figure = new Class2();
            diag.ShowDialog();
            Figure.X = diag.X;
            Figure.Y = diag.Y;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Figure != null)
            {
                Figure.Draw(fig, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            }
            else
                MessageBox.Show("Объект не создан");
        }
    }
}
