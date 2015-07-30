using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _12_Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //list similiar to array
            string[] myarray = new string[4]; //sample array specify total elements

            List<string> names = new List<string>(); //list don't need to specify elements
            names.Add("Chris");
            names.Add("Paine");
            MessageBox.Show(names[0]);
            MessageBox.Show(names[1]);

            List<int> numbers = new List<int>();
            numbers.Add(100);
            numbers.Add(200);

            MessageBox.Show(numbers[1].ToString());
        }
    }
}