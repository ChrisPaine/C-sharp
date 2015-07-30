using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Methods___Creating_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calcWeight(12, 12);
        }

        public void calcWeight(int a, int b) {
            int c;
            c = a * b;
            MessageBox.Show(c.ToString());
        
        }
    }
}
