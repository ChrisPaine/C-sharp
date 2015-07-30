using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _90___ProgressBar_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //value can also be set in properties.
            //progressBar1.Value += 10;
            //progressBar1.PerformStep();//better way and set the step in the prop.

            //change marquee prop, instead of blocks style previously.
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 200;//contiuous scroll accross if you don't know the end.lower the value the faster.
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Blocks;
        }
    }
}
