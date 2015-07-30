using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _32_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {                                                                   //subscriber method void return , sender object , eventargs info, called delegate
            myClass mc = new myClass();
            mc.onPropertyChanged += new EventHandler(mc_onPropertyChanged);
                                                                            //+= tab twice to create below
            mc.Name = "Chris";
        }

        //method will be called
        void mc_onPropertyChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The property has changed");
        }
    }
}
