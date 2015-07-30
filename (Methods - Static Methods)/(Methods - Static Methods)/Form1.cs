using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _Methods___Static_Methods_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mark.testThis();//static don't need to have new.
            Mark m = new Mark();
            m.testThat();//instance method.  check coding standards. some developers like to put all static in one class.

        }
    }


    public class Mark {
        static public void testThis() {
            MessageBox.Show("TestThis()");
        }

        public void testThat() {
            MessageBox.Show("TestThat()...");
        }
    
    
    
    }
}
