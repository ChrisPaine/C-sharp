using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YouTube;

namespace YouTube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myClass mc = new myClass();
            //mc.BirthDay;//combines two classes.
            mc.ShowMessage("Chris");
            
           
        }
    }
}
