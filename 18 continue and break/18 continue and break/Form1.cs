using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _18_continue_and_break
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               //can use breakpoint to the left and F11 to step thru code.
            for (int inc = 0; inc <= 10; inc++ ) {
                if (inc == 5) { break; }
                if (inc == 2) { continue; }
                textBox1.Text += inc.ToString();
            }
        }
    }
}
