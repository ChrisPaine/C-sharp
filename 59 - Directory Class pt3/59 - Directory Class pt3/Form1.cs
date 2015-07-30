using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _59___Directory_Class_pt3{
    public partial class Form1 : Form    {
        public Form1()        {            InitializeComponent();        }

        private void button1_Click(object sender, EventArgs e)        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK){
                Directory.CreateDirectory(fbd.SelectedPath + "\\Chris");//creates folder where user picks.
                Directory.Move(fbd.SelectedPath, "C:\\users\\cpaine\\Desktop\\Paine");//move folder to destination
                Directory.Delete(fbd.SelectedPath);
            }
        }
    }
}
