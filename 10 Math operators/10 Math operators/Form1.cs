using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10_Math_operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 5;
            int b = 3;

            MessageBox.Show((a+b).ToString());
            MessageBox.Show((a * b).ToString());
            MessageBox.Show((a / b).ToString());
            MessageBox.Show((a++).ToString());
            MessageBox.Show((--a).ToString());
        }
    }
}
