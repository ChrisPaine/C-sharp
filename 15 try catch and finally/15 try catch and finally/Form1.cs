using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _15_try_catch_and_finally
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instead of application crashing 
            try {
                string[] names = new string[2];
                string s = names[2];
            }
            catch (Exception ex) {
                MessageBox.Show("Custom message");
                MessageBox.Show(ex.Message);
            }
            finally {
                MessageBox.Show("Your code is done!");//do this last
            }
        }
    }
}
