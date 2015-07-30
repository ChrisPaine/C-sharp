using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _77___DateTime_Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(1965, 02, 22,3,32,52);//24 hour time
            MessageBox.Show(dt.ToString());

            DateTime tt = DateTime.Today; //24 hour time, .now; for date and time.
            MessageBox.Show(tt.ToString());

            MessageBox.Show(DateTime.IsLeapYear(2012).ToString());

            MessageBox.Show(DateTime.DaysInMonth(2013, 03).ToString());

            MessageBox.Show(DateTime.Now.ToFileTime().ToString("x"));
            DateTime ft = DateTime.FromFileTime(longFileTime);//longFileTime is from the file.
        }
    }
}
