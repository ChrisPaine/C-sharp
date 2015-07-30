using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myNamespace;

namespace _21_Access_modifiers_and_static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Chris";
            myClass mc = new myClass(name);
            mc.name();//public
            mc.lastName(); //private can't access.
            //static don't need to create an instance of the class to access static.
            myClass.showMessage("Chris");
        }
    }
}
