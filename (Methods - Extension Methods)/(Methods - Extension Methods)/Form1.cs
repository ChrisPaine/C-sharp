using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _Methods___Extension_Methods_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Mark {
        public void testThis() {
            MessageBox.Show("TestThis()");
        }
    }

    public static class extMark {//static can extention the extMark method to Mark.//contriversal to developers.
        public static void testThat(this Mark em) {
            MessageBox.Show("TestThat()");
        }
    }

}
