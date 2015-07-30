using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _106___WebBrowser_Control_pt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WebBrowser wb = new WebBrowser();
        private void button1_Click(object sender, EventArgs e)
        {
            wb.Navigate("http://halo.bungie.net/stats/default.aspx?player" + textBox1.Text + "&sg=0");
            wb.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_DocumentCompleted);
        }

        void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {   
            //to get element right click on chrome and choose inspect element. doubleclick and get id.
            label1.Text = "Bungie.net " + wb.Document.GetElementById("ctl00_TopContentArea_noStatsMessage").InnerText;
        }
    }
}
