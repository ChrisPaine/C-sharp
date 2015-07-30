using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyNamespace;

namespace _26_More_on_inheritance_and_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySecondClass mc = new mySecondClass();

            myThirdClass mtc = new myThirdClass();

            mtc.Test = "10";// inherites from all classed as dirived.

            
            
        }
    }
}
