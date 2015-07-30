using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace _42_Binary_Reader_prt2{
    public partial class Form1 : Form {
        public Form1(){ InitializeComponent();}

        string path;
        private void button1_Click(object sender, EventArgs e)  {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK){
                button2.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)  {
            BinaryReader br = new BinaryReader(File.OpenRead(path));
            br.BaseStream.Position = 0x1E;// set read position
            byte[] buffer = br.ReadBytes(2);//Read the wrong order 00 01 = 10 00
            Array.Reverse(buffer); // reverse array to 
            textBox1.Text = BitConverter.ToInt16(buffer, 0).ToString("x");//bitconvert to toint16, 32 four bytes use toInt32, ("x") = shows hex, .ToString() = decimal entire number.
            //bitconverter useful = turn a number into byte array.
            br.Dispose();
        }
    }
}
