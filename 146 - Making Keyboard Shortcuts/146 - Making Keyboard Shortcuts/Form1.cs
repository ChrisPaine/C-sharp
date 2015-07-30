using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _146___Making_Keyboard_Shortcuts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //set keypreview of form to true
            //use this event
            if (e.Control && e.KeyCode.ToString() == "A") ;//control a
            {
                MessageBox.Show("control-A");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode.ToString() == "F");//alt- a
            {
                MessageBox.Show("alt-f");
            }
        }
    }
}
