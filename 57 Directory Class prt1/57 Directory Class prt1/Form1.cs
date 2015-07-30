using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _57_Directory_Class_prt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK){
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                foreach(string f in files)
                    MessageBox.Show(f);

                string[] dir = Directory.GetDirectories(fbd.SelectedPath);
                foreach (string d in dir)
                    MessageBox.Show(d);

                string[] drives = Directory.GetLogicalDrives();
                foreach(string d in drives)
                    MessageBox.Show(d);
            }
        }
    }
}
