using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __Methods___Sealed_Methods_
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
            public virtual void Inoculate() { //virtual first part of override.
                //add code here...
            }

            public class Dog : Animal {
                public sealed override void Inoculate()//sealed override syntax
                {
                    MessageBox.Show("Dog:Animal");
                }
            
            }

            public class Cat : Dog {
                public override void Inoculate() {//sealed is preventing override.
                    MessageBox.Show("Cat");
                }
            
            }

        }

    }
}
