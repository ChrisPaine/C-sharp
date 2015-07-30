using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using.Ionic.zip; for new .zip 

namespace _177___Zipping_Files_and_Folders
{
    //download zip for .net from http://dotnetzip.codeplex.com/releases/view/68268
    //add reference to the .net zip

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ZipFile zf = new ZipFile("C:\\Users\\cpaine\\Desktop\\MyZipFile.zip");
                zf.AddDirectoryByName("Adam");
                zf.AddFile(ofd.FileName, "Adam");
                //zf.AddDirectory(fbd.SelectedPath, "");
                if.Save;
            }
        }
    }
}
