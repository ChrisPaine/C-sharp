using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _05_property_of_object_using_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "New Name";
            button1.Enabled = false;
            button1.Height = 60;
            textBox1.Text = "Chris Paine";
            textBox1.MaxLength = 2;
        }
    }
}
