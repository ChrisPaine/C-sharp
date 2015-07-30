using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _33_Ternay_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string myString = "";
            //if (checkBox1.Checked) myString = "It's Checked";
            //else myString = "It's not checked";

            //ternary operator shorter
            string myString = (checkBox1.Checked) ? "It's Checked" :"It's not checked";
            MessageBox.Show(myString);

            //shorter still to one line code.
            //will cutdown on your readibility.
            MessageBox.Show((checkBox1.Checked) ? "It's Checked" : "It's not checked");
           


        }
    }
}
