using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _06_if_statements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Chris") { 
                    MessageBox.Show("Paine");
            }
            else if (textBox1.Text != "Paine")
            {
                MessageBox.Show("Chris");
            }
            else
            {
                MessageBox.Show("Who are you!!");
            }
        }
    }
}
