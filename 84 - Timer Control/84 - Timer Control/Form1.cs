using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _84___Timer_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1000 milliseconds = 1 second
            //set timer intreval on form1.cs design properties. click timer button and choose events.
            timer1.Start();

        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //new tick event
            //after once second show box

            //timer1.Stop();can stop timer
            //MessageBox.Show("Hello");  and show in message box

            i++;
            textBox1.Text += i.ToString();//+= add to text sting not adding up numbers. 1 2 3 4 5 not 1+1+1+1+1
        }
    }
}
