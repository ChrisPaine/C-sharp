using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _66___Bitwise_Operators_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //use calculator to show binary
            short myShort = ~3;//invert op 0000 0000 0000 0011 ~ 1111 1111 1111 1100 = inverted.
            MessageBox.Show(Convert.ToString(myShort,2));
            myShort = ~5;
            MessageBox.Show(Convert.ToString(myShort, 2));
        }
    }
}
