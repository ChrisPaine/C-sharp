using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _68___Bitwise_Operators_pt_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short myShort = 3 ^ 5;//xor 0011 xor 0101 = 0110, 0 ^ 1 = 1, 1 ^ 1 = 0, 0 ^ 0 = 0, 1 ^ 0 = 1
            MessageBox.Show(Convert.ToString(myShort,2)); 

            short myShort2 = 3 >> 1;//shift right, 0011 >> 0001 = 0001
            MessageBox.Show(Convert.ToString(myShort2,2));

            short myShort3 = 5 >> 1;//shift right, 0101 >> 0001 = 0010
            MessageBox.Show(Convert.ToString(myShort3, 2));

            short myShort4 = 5 << 1;//shift left, 0101 >> 0001 = 1010
            MessageBox.Show(Convert.ToString(myShort4, 2));  
        }
    }
}
