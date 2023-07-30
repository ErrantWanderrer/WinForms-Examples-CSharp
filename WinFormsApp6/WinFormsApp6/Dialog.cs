using System;
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
    public partial class Dialog : Form
    {
        public int X, Y;
        public Dialog()
        {
            InitializeComponent();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            X = Convert.ToInt32(textBox1.Text);
            Y = Convert.ToInt32(textBox2.Text);
            ActiveForm.Close();
        }
    }
}
