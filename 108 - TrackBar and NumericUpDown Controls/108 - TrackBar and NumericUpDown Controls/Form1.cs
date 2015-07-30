using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _108___TrackBar_and_NumericUpDown_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //form prop can set the max,min, tick frequency
        //horiz or vert on prop on form view.
        //can change tick side or disable.
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(trackBar1.Value.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //masked textbox 
            //can change on prop form view:
            //min/max
            //increment
        }
    }
}
