using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _61___File_Class_pt_2{
    public partial class Form1 : Form    {
        public Form1()        {            InitializeComponent();        }

        private void button1_Click(object sender, EventArgs e)        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==DialogResult.OK){
                File.Copy(ofd.FileName, "C:\\temp\\renameFile.txt");
                File.Move(ofd.FileName, "C:\\temp\\renameFile.txt");
            
            }
        }
    }
}
