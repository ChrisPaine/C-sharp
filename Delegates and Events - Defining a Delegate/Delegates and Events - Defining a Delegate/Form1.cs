using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Delegates_and_Events___Defining_a_Delegate
{
    //delagates have scope at namespace level
    delegate void del1();//only point to methods with void and not params.
    delegate void del2(int a);//point to any method with single int param no return.
    delegate int del3(int a, int b);// int return, two int params

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
