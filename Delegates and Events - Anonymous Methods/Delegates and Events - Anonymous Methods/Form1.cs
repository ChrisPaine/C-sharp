using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Delegates_and_Events___Anonymous_Methods
{
    delegate int del3(int a, int b);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //del3 dAdd;
            //dAdd = method3;
            //int result = dAdd(4, 5);
            del3 dAdd2 = delegate(int x, int y){//do this anonymous method
                return x + y;
            };

            MessageBox.Show("dAdd2 "+dAdd2(6,5));
        }
        //public int method3(int x, int y) {
            //return x + y;
        //}
    }
}
