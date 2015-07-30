using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _09_Switch_Statement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text) { 
                case "Chris":
                    MessageBox.Show("Paine");
                    break;
                case "Paine":
                    MessageBox.Show("Chris");
                    break;
                default:
                    MessageBox.Show("Your name is not entered");
                    break;
            
            }
        }
    }
}
