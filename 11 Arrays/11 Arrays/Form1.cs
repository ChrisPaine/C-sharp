using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _11_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] names = {"Chris","Paine","Dresden","Maine"};
            MessageBox.Show(names[0]);

            int[] numbers = {1,2,3,4,5,6 };
            MessageBox.Show(numbers[3].ToString());
        }
    }
}
