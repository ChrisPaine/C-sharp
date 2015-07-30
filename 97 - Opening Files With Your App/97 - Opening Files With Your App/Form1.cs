using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _97___Opening_Files_With_Your_App
{
    public partial class Form1 : Form
        //1) right click on form and chooses view code.
    {

        public Form1(string s)//constructor pass path thru s string
        {
            //2) on solution explorer doubleclick on 'Program.cs'
            InitializeComponent();
            MessageBox.Show(s);//3) create message box
            //copy this program to a folder and drag and drop file on top of this exe to show path in mbox.
            //compile first to get exe.
        }
    }
}
