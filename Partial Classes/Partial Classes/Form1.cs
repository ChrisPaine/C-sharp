using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Partial_Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //two developers can work on same class.
            Mark b = new Mark();//right click and definitions.
            b.testThat();
            b.testThis();//diff class
        }
    }
    public partial class Mark
    {
        public void testThis() { 
            //code here...
        
        }
    }
}
