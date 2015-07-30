using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myNamespace;

namespace _25_Inheritance_and_Overloading
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
            MessageBox.Show(mc.age.ToString());     //member of myclass.
            MessageBox.Show(mc.hairColor);          // member of second class.
            MessageBox.Show(mc.Name);               //protected can't access.
        }
    }
}
