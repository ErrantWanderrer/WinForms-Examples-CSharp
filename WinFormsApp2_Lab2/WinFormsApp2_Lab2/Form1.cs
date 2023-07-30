using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Trapezoid trap = new();
        Trapezoid trap1 = new();
        Trapezoid trap2 = new(15, 10, 5);
        Trapezoid trapLink;

        public class Trapezoid
        {
            private float lengthHigh;
            private float lengthLow;
            private float height;

            public Trapezoid()
            {
                lengthHigh = 20;
                lengthLow = 15;
                height = 4;
            }
            public Trapezoid(float high, float low, float h)
            {
                lengthHigh = high;
                lengthLow = low;
                height = h;
            }

            public float GetLengthHigh()
            {
                return lengthHigh;
            }

            public float GetLengthLow()
            {
                return lengthLow;
            }

            public float GetHeight()
            {
                return height;
            }

            public void SetLengthHigh(float high)
            {
                if (high < 0)
                {
                    MessageBox.Show("Значение должно быть больше нуля");
                }
                else
                {
                    lengthHigh = high;
                }
            }

            public void SetLengthLow(float low)
            {
                if (low < 0)
                {
                    MessageBox.Show("Значение должно быть больше нуля");
                }
                else
                {
                    lengthLow = low;
                }
            }

            public void SetHeight(float h)
            {
                if (h<1 || h>8)
                {
                    MessageBox.Show("Высота должна быть задана в границах от: 1 до 8");
                }
                else
                {
                    height = h;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trapezoid trap = new();
            trap.SetLengthHigh(Convert.ToSingle(textBox1.Text));
            trap.SetLengthLow(Convert.ToSingle(textBox2.Text));
            trap.SetHeight(Convert.ToSingle(textBox3.Text));
            textBox4.Text = (trap.GetLengthHigh() + trap.GetLengthLow() + 2 * Math.Sqrt(Math.Pow(trap.GetHeight(), 2) + (trap.GetLengthHigh() - Math.Pow(trap.GetLengthLow(), 2)) / 4)).ToString();
            textBox5.Text = ((trap.GetHeight() * (trap.GetLengthHigh() + trap.GetLengthLow()))/2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if ((radioButton1.Checked = true) || (radioButton2.Checked = true) || (radioButton3.Checked = true))
            //{
                trapLink.SetLengthHigh(15);
                trapLink.SetLengthLow(10);
                trapLink.SetHeight(5);
            //}
            //else
              //  MessageBox.Show("объект не выбран");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if ((radioButton1.Checked = true) || (radioButton2.Checked = true) || (radioButton3.Checked = true))
            //{
                textBox1.Text = trapLink.GetLengthHigh().ToString();
                textBox2.Text = trapLink.GetLengthLow().ToString();
                textBox3.Text = trapLink.GetHeight().ToString();
                textBox4.Text = (trapLink.GetLengthHigh() + trapLink.GetLengthLow() + 2 * Math.Sqrt(Math.Pow(trapLink.GetHeight(), 2) + (trapLink.GetLengthHigh() - Math.Pow(trapLink.GetLengthLow(), 2)) / 4)).ToString();
                textBox5.Text = ((trapLink.GetHeight() * (trapLink.GetLengthHigh() + trapLink.GetLengthLow())) / 2).ToString();
            //}
            //else
               // MessageBox.Show("объект не выбран");       
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            trapLink = trap;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            trapLink = trap1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            trapLink = trap2;
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string text = textBox1.Text;
            //trap.lengthHigh = Convert.ToSingle(text);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //string text = textBox2.Text;
            //trap.lengthLow = Convert.ToSingle(text);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //string text = textBox3.Text;
            //trap.height = Convert.ToSingle(text);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
