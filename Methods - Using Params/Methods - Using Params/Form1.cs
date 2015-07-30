using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Methods___Using_Params
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] vals = {10,15,18,33,44,66,54 };
            label1.Text = calc(20,25,6,3).ToString();//passing array to calc in funstion or method.
            //will take negative numbers.
        }

        public int calc(params int[] nbrs) {
            int total = 0;
            foreach (int i in nbrs)
            {
                total += 1;
            }
            return total;
        
        }

    }
}
