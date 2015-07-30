using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;//string are a object.
            string b = "ar";
            label1.Text = a;
            label2.Text = a.Length.ToString();//a has methods like objects.
            label3.Text = b.Contains(b).ToString();//if b contains 'ar' in a.
            label4.Text = a.ToUpper();

        }
    }
}
