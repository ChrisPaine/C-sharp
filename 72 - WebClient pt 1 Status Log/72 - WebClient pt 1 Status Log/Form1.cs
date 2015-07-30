using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace _72___WebClient_pt_1_Status_Log
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //way to share status with freinds
        //status.txt saved in coding folder C#
        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            textBox1.Text = wc.DownloadString("http://www.weebly.com/uploads/2/3/0/7/23078600/status.txt");
        }
        //http://dresdenmaine.weebly.com/
        //http://www.weebly.com/weebly/main.php#
    }
}
