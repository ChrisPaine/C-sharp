using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringBuilder_prt1
{
    public partial class Form1 : Form
    {
        //less overhead for creating and destroying objects.
        //regular string will not destroy change strings but create a new.
        //class level, a is stringbuilder class object
        StringBuilder a = new StringBuilder(5); //5 is capacity, will double at runout to 10 then 15, if set 25 goto 50
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.Append(textBox1.Text);
            label1.Text = a.ToString();
            label2.Text = a.Length.ToString() + Environment.NewLine + a.Capacity.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.Clear();

        }
    }
}
