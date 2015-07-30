using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // for stream writer.

namespace _40_Stream_Writer_pt2{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        //http://www.youtube.com/watch?v=uEcwwjB7Fg4

        string path;
        private void button1_Click(object sender, EventArgs e){
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                button2.Enabled = true;
                path = ofd.FileName;            
            }
        }

        private void button2_Click(object sender, EventArgs e){
            StreamWriter sw = new StreamWriter(File.OpenWrite(path));
            sw.BaseStream.Position = 0x1e;
            sw.BaseStream.WriteByte(0xff);//write bytes of code in hex 0x.

            //byte[] buffer = { 0x08, 0x09, 0x0A };//create byte array for writing multi lines.
            //sw.BaseStream.Write(buffer,0,3);//(buffer array,offset,how many bytes in array)
            
            sw.Dispose();
        }









    }
}
