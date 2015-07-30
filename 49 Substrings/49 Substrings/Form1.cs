using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//no using strings;

namespace _49_Substrings{
    public partial class Form1 : Form    {        public Form1()        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)        {
            string name = "John Smith";
            string Firstname = name.Substring(0, 4);
            MessageBox.Show(Firstname);
            string Lastname = name.Substring(5, 5);
            MessageBox.Show(Lastname);

        }
    }
}
