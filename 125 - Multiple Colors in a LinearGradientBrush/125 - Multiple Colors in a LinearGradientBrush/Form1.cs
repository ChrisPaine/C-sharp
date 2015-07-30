using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _125___Multiple_Colors_in_a_LinearGradientBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(20,20),new Point(20,70),Color.Black,Color.Red);
            Graphics g = panel1.CreateGraphics();
            ColorBlend cb = new ColorBlend();
            cb.Colors = new Color[] { Color.Black,Color.Blue,Color.White};
            //float array diff between two number be equal .5 between each number.
            cb.Positions = new float[] { 0, .5F,1F};//float array, postions center of color, black,blue,white, F to convert to float.
            lgb.InterpolationColors = cb;
            g.FillRectangle(lgb,20,20,50,50);
        }
    }
}
