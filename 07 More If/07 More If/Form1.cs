using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _07_More_If
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true) { 
            if (checkBox1.Checked)
            {
                //if (!checkBox1.Checked) { 
                MessageBox.Show("Check box checked");
            }
            bool mybool = true;
            if (mybool)
            {
                MessageBox.Show("True");
            }
            int a = 11;
            int b = 12;
            int c = 15;

            if (a < c)
            {
                MessageBox.Show("True");
            }
        }
    }
}
