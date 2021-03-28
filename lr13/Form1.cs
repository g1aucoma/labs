using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxa.SelectedIndex = 0;
            comboBoxb.SelectedIndex = 0;
        }

        private void comboBoxa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double z = 0;
            double x = Convert.ToDouble(textBoxX.Text);
            double y = Convert.ToDouble(textBoxY.Text);
            int n = Convert.ToInt32(textBoxN.Text);
            int r = Convert.ToInt32(textBoxR.Text);
            double a = Convert.ToDouble(comboBoxa.SelectedItem.ToString());
            double b = Convert.ToDouble(comboBoxb.SelectedItem.ToString());

            if (radioButton1.Checked)
            {
                int k = 2; int v = 3;
                z = 1; double item = 0;
                for (int i = 1; i < n; i++)
                {
                    item = (i % 2 == 0) ? y : x;
                    z += (Math.Pow(-1, i % 2) * Math.Pow(item, i))/(k*v);
                    k *=v;
                    v++;
                }
            }
            else
            {
                z = 0;
                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < r; j++)
                    {
                        z += (3 + a * j) / (b * i);
                    }
                }
            }

            textBoxZ.Text = z.ToString();
        }

    }
}
