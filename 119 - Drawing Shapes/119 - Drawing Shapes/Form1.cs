using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _119___Drawing_Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //event: click
            SolidBrush sb = new SolidBrush(Color.Red);
            Graphics g = panel1.CreateGraphics();
            g.FillEllipse(sb, 20, 20, 50, 50);//0,0 top left in pixels
            g.FillRectangle(sb, 20, 20, 50, 50);
        }
    }
}
