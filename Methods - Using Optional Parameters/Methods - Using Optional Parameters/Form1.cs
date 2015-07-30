using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Methods___Using_Optional_Parameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    //    private void button1_Click(object sender, EventArgs e)//overloading
    //    {
    //        int total = calc(5, 12, 3);
    //        MessageBox.Show(total.ToString());
    //    }
    //    public int calc(int x, int y, int div) {
    //        return (x * y / div);
    //    }

    //    public int calc(int x, int y)
    //    {
    //        return calc(x * y, 2);//recall recursion.
    //    }

    //    public int calc(int x)
    //    {
    //        return calc(x, 10);
    //    }
    //}

        public int calc(int x, int y =10, int div = 2){//same as above using option values!!
            return (x*y/div);
        }


}
