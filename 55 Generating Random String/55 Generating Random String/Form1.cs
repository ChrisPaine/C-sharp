using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _55_Generating_Random_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            MessageBox.Show(letters[r.Next(0,25)].ToString());//gen random number index char array
            string rand = "";
            for (int i = 0; i < 10; i++) { 
                rand += letters[r.Next(0,25)].ToString();
                MessageBox.Show(rand);
            }
        }
    }
}
