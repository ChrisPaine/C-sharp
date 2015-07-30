using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _127___PathGradientBrush_pt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            ////GraphicsPath gp = new GraphicsPath();
            ////Point[] points = { new point(20,20), new Point(20,70), new Point(70,20)};
            ////gp.AddPolygon(points);
            ////PathGradientBrush pgb = new PathGradientBrush(gp);
            ////pgb.CenterColor = Color.White;
            ////pgb.SurroundColors = new Color[] { Color.Black};
            ////Graphics g = panel1.CreateGraphics();
            ////g.FillPolygon(pgb,points);

            GraphicsPath gp = new GraphicsPath();
            Rectangle r = new Rectangle(20, 20, 50, 50);
            gp.AddRectangle(r);
            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = Color.White;
            pgb.SurroundColors = new Color[] { Color.Black };
            Graphics g = panel1.CreateGraphics();
            g.FillRectangle(pgb, r);


        }
    }
}
