using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _47_is_as_and_casting{
    public partial class Form1 : Form    {
        public Form1()        {            InitializeComponent();        }

        private void button1_Click(object sender, EventArgs e)        {
            object myObj = "Chris";
            //string myString = myObj as string;
            if (myObj is string) { MessageBox.Show((string)myObj); }


            Control myControl = button1;
            if (myControl is Button) {//using is keyword to test
                Button myButton = (Button)myControl;
                //Button myButton = myControl as Button;//same as above
            }
        }
    }
}
