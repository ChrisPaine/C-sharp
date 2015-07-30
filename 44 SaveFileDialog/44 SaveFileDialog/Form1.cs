using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _44_SaveFileDialog{
    public partial class Form1 : Form    {
        public Form1()        {            InitializeComponent();        }
        
        private void button1_Click(object sender, EventArgs e)        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";//default type
            sfd.FileName = "MyTextFile";// default name
            sfd.Title = "Save Title"; // title name
            if (sfd.ShowDialog() == DialogResult.OK){
                
                string path = sfd.FileName;
                BinaryWriter bw = new BinaryWriter(File.Create(path));
                bw.Write("This is a test");
                bw.Dispose();
            }

            
        }
    }
}
