using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __Delegates_and_Events___Simple_Delegate_Example_pt._1_
{
    delegate void del1();
    delegate void del2(int a);
    delegate int del3(int a, int b);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            del1 d1 = new del1(method1);//pass address with no params par
            d1();

            del2 d2 = new del2(method2);
            d2(5);

            del2 d3;
            d3 = method2;
            d3(12);

            del3 dAdd;
            dAdd = method3;
            int res = dAdd(4, 5);
            MessageBox.Show("method3 "+res);



        }
        public void method1() {
            MessageBox.Show("Method1");
        }

        public void method2(int a)
        {
            MessageBox.Show("Method2"+a);
        }

        public int method3(int a, int b)
        {
            MessageBox.Show("Method3");
            return a + b;
        }
    }
}
