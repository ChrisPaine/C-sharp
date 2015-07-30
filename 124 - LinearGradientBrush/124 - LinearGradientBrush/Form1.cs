using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _124___LinearGradientBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(20,20), new Point(20,70),Color.Red, Color.Yellow);//second point to 70,20 to change gradiant direction.
            Graphics g = panel1.CreateGraphics();
            g.FillRectangle(lgb,20,20,50,50);
            g.FillEllipse(lgb,20,20,50,50);
        }
    }
}
