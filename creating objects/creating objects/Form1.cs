using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace creating_objects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chris c = new chris();//new instance of class now object
            c.clp();
            c.a = 103;

            chris p = new chris();// new object from same class.
            p.clp();
        }
    }

    class chris
    {
        public int a = 34;//three fields
        public int b = 56;
        public int c = 67;

        public void clp() {//method
            MessageBox.Show("Hello!");
        }
    }
}
