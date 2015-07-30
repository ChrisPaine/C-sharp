using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _Methods___Hiding_Methods_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.Inoculate();
        }

        public class Animal {
            public void Inoculate() {
                MessageBox.Show("Animal has inoculated...");
            }}


        public class Cat : Animal//inherite
        {
            new public void Inoculate()//problem squigglies, Cat inoculate is hiding animail inoculate. NEW fixes.
                //squigglies will go away when recompile.
            {
                base.Inoculate();// will run bas animal method.
                MessageBox.Show("Cat has inoculated...");
            }
        }

        
    }
}
