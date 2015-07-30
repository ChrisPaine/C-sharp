using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _08_If_more_prt3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "Chris" && checkBox1.Checked == true) {
                    //MessageBox.Show("Checked Hello");
                //}
             
                //}
                if (textBox1.Text == "Chris" || checkBox1.Checked == true) {
                    MessageBox.Show("Checked Hello");
                }
             
                 }
        }
}
