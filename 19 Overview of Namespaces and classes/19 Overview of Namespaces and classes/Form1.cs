using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;  //system, inside windows, inside forms are all namespace.
using myNamespace;  //to access your defined namespace.

namespace _19_Overview_of_Namespaces_and_classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show if you didn't using System.Windows.Forms above. 
            //Have to type out all.
        }
    }
}
