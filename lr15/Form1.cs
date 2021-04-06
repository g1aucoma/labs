using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                BackColor = dlg.Color;
            }
        }

        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowHelp = true;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                btnChooseFont.Font = dlg.Font;
                btnChooseColor.Font = dlg.Font;
                btnChooseFK.Font = dlg.Font;
                label1.Font = dlg.Font;
                label2.Font = dlg.Font;
                label3.Font = dlg.Font;
                label4.Font = dlg.Font;
                label5.Font = dlg.Font;
                txtTerm.Font = dlg.Font;
                txtAnswer.Font = dlg.Font;
                txtX.Font = dlg.Font;
                txtZ.Font = dlg.Font; 
                txtT.Font = dlg.Font;
                btnCalc.Font = dlg.Font;
            }
        }

        private void btnChooseFK_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btnChooseFont.ForeColor = dlg.Color;
                btnChooseColor.ForeColor = dlg.Color;
                btnChooseFK.ForeColor = dlg.Color;
                label1.ForeColor = dlg.Color;
                label2.ForeColor = dlg.Color;
                label3.ForeColor = dlg.Color;
                label4.ForeColor = dlg.Color;
                label5.ForeColor = dlg.Color;
                txtTerm.ForeColor = dlg.Color;
                txtAnswer.ForeColor = dlg.Color;
                txtX.ForeColor = dlg.Color;
                txtZ.ForeColor = dlg.Color;
                txtT.ForeColor = dlg.Color;
                btnCalc.ForeColor = dlg.Color;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double z = Convert.ToDouble(txtZ.Text);
            double x = Convert.ToDouble(txtX.Text);
            double t = Convert.ToDouble(txtT.Text);
            int n = Convert.ToInt32(txtTerm.Text);
            double ans = 1;
            double item;

            for(int i = 2; i <= n; i++)
            {
                item = (i % 2 == 0) ? -(Math.Pow(Math.Cos(x * t), i)) / i : Math.Pow(Math.Sin(x * z), i) / i;
                ans += item;
            }

            txtAnswer.Text = ans.ToString();
        }
    }
}
