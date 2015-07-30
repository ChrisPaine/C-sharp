using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _45_Convert_Class
{
    public partial class MyVersion : Form    {
        public MyVersion()        {            InitializeComponent();        }

        private void button1_Click(object sender, EventArgs e)        {
            //textbox generaly string type, type cast to int.
            //convert class is static.
            try// good practice
            {
                //heavily overloaded convert class
                int myInt = Convert.ToInt32(textBox1.Text);// can treat as a numer + 2 or * 2
                MessageBox.Show(myInt.ToString());

                char myChar = Convert.ToChar(textBox2.Text);
                MessageBox.Show(myChar.ToString());

                bool myBool = Convert.ToBoolean(textBox3.Text);
                MessageBox.Show(myBool.ToString());
            }
            catch { MessageBox.Show("Conversion Failed"); }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
