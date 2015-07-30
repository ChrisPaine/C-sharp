using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _52_Split_and_to_CharArray{
    public partial class Form1 : Form    {
        public Form1()        {            InitializeComponent();        }

        private void button1_Click(object sender, EventArgs e)        {
            string name = "Chris;Dianne;Justin;Alica;Seth;Shadow";
            string[] nameArray = name.Split(';');//string array base on delineated values
            foreach(string names in nameArray)
                MessageBox.Show(names);

            string _letters = "abcdefg";
            char[] letters = _letters.ToCharArray();
            foreach(char lets in letters)
                MessageBox.Show(lets.ToString());//need to cast as string not char
        }
    }
}
