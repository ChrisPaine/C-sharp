using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaticClassExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // not instances
            //quick and easy
            Mark.weight = 145;
            Mark.callVTC();//static don't need to create.

            //Mark m = new Mark();
            //m. don't work.
        }
    }

    public static class Mark {
        public static int weight;

        public static void callVTC() {
            MessageBox.Show("Called VTC...");
        }
        //public void bob() { }not static
    
    }
}
