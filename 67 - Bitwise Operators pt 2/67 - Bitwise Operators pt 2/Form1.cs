using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _67___Bitwise_Operators_pt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short myShort = 3 & 5;//compares two number at the binary level, one and. 0011 and 1001 = 0001
            MessageBox.Show(Convert.ToString(myShort,2));

            short myShort2 = 3 & 4;//compares two number at the binary level, one and. 0011 and 0100 = 0000
            MessageBox.Show(Convert.ToString(myShort2, 2));

            short myShort3 = 3 | 5;//compares two number at the binary level, one and. 0011 and 0101 = 0111
            MessageBox.Show(Convert.ToString(myShort3, 2));
        }
    }
}
