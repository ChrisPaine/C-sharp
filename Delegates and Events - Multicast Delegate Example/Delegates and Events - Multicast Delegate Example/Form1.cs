using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Delegates_and_Events___Multicast_Delegate_Example
{
    delegate void del1();//no param signature.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //del1 d1 = new del1(method1);
            //d1();
             
            //added multi methods to a delegate to create multi cast delegate
            del1 d2 = new del1(method1);//multi cast delegates
            d2 += method2;
            d2 += method3;
            d2();
        }




        public void method1() {
            MessageBox.Show("method1");
        }

        public void method2() {
            MessageBox.Show("method2");
        }

        public void method3() {
            MessageBox.Show("method3");
        }
        
    }
}
