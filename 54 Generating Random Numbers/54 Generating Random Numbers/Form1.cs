using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _54_Generating_Random_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            MessageBox.Show(r.Next().ToString() );

            MessageBox.Show(r.Next(0,100).ToString());

            byte[] buffer = new byte[5];
            Random rx = new Random();
            r.NextBytes(buffer);//fill byte array with random bytes
            MessageBox.Show(BitConverter.ToString(buffer));

            MessageBox.Show(rx.NextDouble().ToString());//random double
        }
    }
}
