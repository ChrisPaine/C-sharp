using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Chris Paine";
            int number = 911;
            bool red = false;
            object myObject = true;

            //MessageBox.Show(name);
            //MessageBox.Show(number.ToString());
            //MessageBox.Show(red.ToString());
            MessageBox.Show(myObject.ToString());
      
        }
    }
}
