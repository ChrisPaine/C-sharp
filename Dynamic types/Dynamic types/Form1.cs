using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dynamic_types
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 3;
            c = "hello";//wrong
            MessageBox.Show(c);//wrong

            dynamic a = 3;//so we can work with the older COM enviroments and data types.
            a = "hello";
            MessageBox.Show(a);

            dynamic b = "hello";
            b = 3;
            MessageBox.Show(b).tostring();
        }
    }
}
