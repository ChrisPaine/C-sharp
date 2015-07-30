using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _17_Method_pt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myMethod("Chris"));//method repersents a string.
            MessageBox.Show(math(12,12).ToString());
        }
        int math(int x,int y){
            return x*y;
        }
        
        string myMethod(string name) {

            return name;
        }
    }
}
