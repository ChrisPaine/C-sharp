using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Methods___Overloading_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testThis(3);//when hit the first ( you see a drop down arrow box, which shows you the overloads.
        }

        public void testThis() {//overloaded nothing passed.
            MessageBox.Show("TestThis()");
        }

        public void testThis(int a)//overloaded depending on what is passed.
        {
            MessageBox.Show("overloaded int a");
        }

        public void testThis(int a,string b)//overloaded depending on what is passed.
        {
            MessageBox.Show("overloaded int a, string b");
        }

        public void testThis(string b, int a)//overloaded depending on what is passed.
        {
            MessageBox.Show("overloaded int a, string b reversed and order");
            
        }
    }
}
