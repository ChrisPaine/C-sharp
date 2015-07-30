using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _50_IndexOf_and_Trim{
    public partial class Form1 : Form    {
        public Form1()        {            InitializeComponent();        }

        private void button1_Click(object sender, EventArgs e)        {
            string name = "John Smith";
            string FirstName = name.Substring(0, name.IndexOf(' '));//space index
            MessageBox.Show(FirstName);
            string LastName = name.Substring(name.IndexOf(' ') + 1);//only need one index value
            MessageBox.Show(LastName);

            string calendar = "   12/12/12   ";
            string fixcalendar = calendar.Trim();//all space start and end
            string fixcalendar2 = calendar.TrimStart();// start trim only
            string fixcalendar3 = calendar.TrimEnd();// end trim only
            MessageBox.Show(fixcalendar);
        }
    }
}
