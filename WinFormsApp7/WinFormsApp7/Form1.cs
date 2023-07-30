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

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        VecList list = new VecList();
        Graphics fig;

        public Form1()
        {
            InitializeComponent();
            fig = Graphics.FromHwnd(Handle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.setGraphics(fig);
            Vector vec = new Vector(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            list.Add(vec);
            Debug.WriteLine(list.getPos());
            Debug.WriteLine(list.List[list.getPos()].getX());
            Debug.WriteLine(list.List[list.getPos()].getY());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Del();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.NextPos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.PreviousPos();
        }
    }
}
