using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _107___WebBrowser_Control_pt_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("p_13838465-p").InnerText = textBox1.Text;//goto url right click to 'inpect element' get id, copy/paste.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("search-submit").InvokeMember("Click");//search button
            //could not find script to search for click event on webpage.
        }
    }
}
