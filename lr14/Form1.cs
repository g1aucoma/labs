using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr14
{
    public partial class Form1 : Form
    {
        DateTimeFormat dtFormat = DateTimeFormat.ShowTime;
        ToolStripMenuItem currentCheckedItem;
        public Form1()
        {
            InitializeComponent();
            Text = "Пример строки состояния";
            CenterToScreen();
            BackColor = Color.CadetBlue;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(toolStripTextBoxX.Text);
            double y = Convert.ToDouble(toolStripTextBoxY.Text);
            double z = Convert.ToDouble(toolStripTextBoxZ.Text);
            double a = Convert.ToDouble(toolStripComboBoxA.SelectedItem.ToString());
            double b = Convert.ToDouble(toolStripComboBoxB.SelectedItem.ToString());
            Text = string.Format(" a * x + b * y  sin(z) = {0} ", (a * x + b * y + Math.Sin(z).ToString()));
        }
        private void timerDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            string info = "";
            if (dtFormat == DateTimeFormat.ShowTime)
                info = DateTime.Now.ToLongTimeString();
            else
                info = DateTime.Now.ToLongDateString();
            toolStripStatusLabelClock.Text = info;
        }
        private void toolStripMenuItem1_Click(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = e.X + e.Y.ToString();
        }
        private void toolStripMenuItem2_Click(object sender, MouseEventArgs e)
        {
             toolStripStatusLabel1.Text = e.X * e.X + Math.Pow(e.Y, 2).ToString();
        }
        
        private void toolStripMenuItemDate_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowDate;
            currentCheckedItem = toolStripMenuItemDate;
            currentCheckedItem.Checked = true;
        }
        private void toolStripMenuItemTime_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowTime;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }
        public enum DateTimeFormat
        {
            ShowTime,
            ShowDate
        }

        public void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelState.Text = string.Format("Координаты: {0}, {1}", e.X, e.Y);
            double x = e.X;
        }

       
    }
    
}
