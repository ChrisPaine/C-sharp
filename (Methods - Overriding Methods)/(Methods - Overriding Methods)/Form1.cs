using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _Methods___Overriding_Methods_
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

        public class Animal {
            public virtual bool checkAccount() { //marked base class to override and use the other method.
                //add code check database ...
                return true;
            }

         public class Dog {
            public int heartWorms(DateTime d) {
                int cc = 5;
                //add code...
                return cc;
             }
         }

         public override bool checkAccount() { //mark to override the above inherited 
            //add code...
             return true;
         }
        }

    }
}
