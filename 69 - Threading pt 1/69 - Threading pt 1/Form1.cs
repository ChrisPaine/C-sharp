using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _69___Threading_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread t;// to access thread in anyone of the methods
        private void button1_Click(object sender, EventArgs e)
        {
            //only way to stop is stop debugging, or task manager
            //Freeze(); before background threading windows would not repond
            t = new Thread(Freeze);
            t.Start();
        }

        //threading will allow method to run in background but will not stop normally when form is closed.
        void Freeze() {
            for (; ; ) ;//infinate loop
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();//will exit out of the application running in the background.
        }
    }
}
