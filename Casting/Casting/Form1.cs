using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int stores  -2,147,486,648 to 2,147,483,647
            //short stores -32,768 to 32,767


            short s = 15000;
            int i = s;

            MessageBox.Show(i.ToString());//=15000


            int ii = 15000;
            short ss = (short)ii;//cast

            MessageBox.Show(ss.ToString());//15000

            int iii = 32768;
            short sss = (short)ii;//cast

            MessageBox.Show(sss.ToString());//=-32768 going backward be careful
        }
    }`
}
