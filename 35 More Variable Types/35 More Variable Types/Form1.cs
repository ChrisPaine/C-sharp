using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _35_More_Variable_Types
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte myByte = 255;//unsigned 0-255
            sbyte Mysbyte = -124;

            short myShort = 0;// ushort unsigned
            Int16 myInt16 = myShort;
            int myint = 32;
            Int32 myint32 = myint;
            long mylong = 8;
            Int64 myInt64 = mylong;

            float myFloat = 224442.11F;//seven digits long
            double mydouble = .12344;

            char myChar = 'D';

        }
    }
}
