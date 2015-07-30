using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _24_Throwing_an_exceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try// try stops prog from crashing with the catch method.
            {
                myClass.CheckString("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
