using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Methods___By_Val_and_By_Ref_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myInt = 20;
            MessageBox.Show("Value before "+ myInt);
            testVal(myInt);
            MessageBox.Show("Value after "+ myInt);

            MessageBox.Show("Value before ref " + myInt);
            testRef(ref myInt);
            MessageBox.Show("Value after ref " + myInt);
        }
        
        //class level
        public void testVal(int a)
        {
            a = a - 4;
            MessageBox.Show("Passed in method " + a);
        }

        public void testRef(ref int a) {
            a = a - 4;
            MessageBox.Show("Passed in method " + a);
        
        }

    }



}
