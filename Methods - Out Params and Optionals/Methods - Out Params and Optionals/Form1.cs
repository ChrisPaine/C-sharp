using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Methods___Out_Params_and_Optionals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int o;//initialize out as o
            label1.Text = "Result: " + Calc(5, 4, out o) + " Diff " + o;// left goes left normal, output paramater goes to right.
        }

        public int Calc(int a, int b, out int diff) {
            int c = a * b;
            diff = 100 - c;
            return c;
        }
    }
}
