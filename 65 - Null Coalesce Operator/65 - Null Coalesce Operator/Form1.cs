using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _65___Null_Coalesce_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myString = null;
            if (myString == null)
            {
                MessageBox.Show("Is null!");
            }
            else {
                MessageBox.Show(myString);
            }

            string qq = null;
            MessageBox.Show(qq ?? "This is null shorthand");//?? shorthand then ternary operator

            int? i = null;//?? for null tests.
            int x = i ?? 8;
            MessageBox.Show(x.ToString());
        }
    }
}
