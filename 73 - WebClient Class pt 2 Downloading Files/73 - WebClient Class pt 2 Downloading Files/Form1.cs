using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace _73___WebClient_Class_pt_2_Downloading_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //new webhost site weebly
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog()==DialogResult.OK){
                WebClient wc = new WebClient();
                wc.DownloadFileAsync(new Uri("http://www.weebly.com/uploads/2/3/0/7/23078600/status.txt"), sfd.FileName);//will thread auto
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);//tab twice to get class and event
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);//+= tab twice will finish line and add event
            }

        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            label1.Text = "Progress: %" + e.ProgressPercentage.ToString();//progress 
        }

        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File downloaded");
        }
    }
}
