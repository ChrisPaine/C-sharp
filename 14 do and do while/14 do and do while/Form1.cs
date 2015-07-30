using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _14_do_and_do_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inc = 0;
            while(inc < 10){//(true) infinite loop
                textBox1.Text += inc.ToString();
                inc++;
            }

            int k = 0;
            do{
                textBox1.Text += k.ToString();
                k++;
            } while (k < 10);//(something static like true) = (true) infinate loop
        }
    }
}
