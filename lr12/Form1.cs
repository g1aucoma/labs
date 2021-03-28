using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();
            double a, b, w;
            a = Convert.ToDouble(textBox3.Text);
            b = Convert.ToDouble(textBox4.Text);
            w = Convert.ToDouble(textBox5.Text);
            textBox6.Text = (Math.Sqrt(Math.Abs(a * e.X / Math.Pow(w, a))) + Math.Sqrt(Math.Abs(b)) - Math.Abs(e.X + Math.Cos(e.Y))).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
