using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myNamespace;

namespace _30_Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //myClass mc = new myClass();//abstract blocks creation.
            //mc. prevent users from createing instance.

            MyClass.Age = 10;

            mySecondClass test = new mySecondClass();

            test.showMessage("Hello World!");

        }
    }
}
