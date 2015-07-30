using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace scope
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 54;//scope is now for the class.
        private void button1_Click(object sender, EventArgs e)
        {
            //a is scoped in this block at first then moved up.
            //int a = 54; was here at first.
            a = 54;
            MessageBox.Show(a.ToString());
        }
        private void chris() { 
            int b = a;
        }
    }//a is scoped to here.
}
