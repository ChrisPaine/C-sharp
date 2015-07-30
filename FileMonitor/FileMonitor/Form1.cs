using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "O:\\Everyone\\PDP\\Dispatch\\Dispatch_032112\\dispatch_export.xls";
            
            System.IO.FileInfo file = new System.IO.FileInfo(fileName);

            listView1. fileName + " " + file.LastWriteTime;

            string fileName2 = "O:\\Programming\\RevChanges\\CncProgramdb.txt";
            System.IO.FileInfo file2 = new System.IO.FileInfo(fileName2);
            
            listBox1.Text = fileName2 + " " + file2.LastWriteTime;

        }

        class fileDate
        {
            public fileDate(FileName)
            {
                string fname = FileName;
            }
        


}
