using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _41_Binary_Reader_prt1{
    public partial class Form1 : Form    {
        public Form1()        {
            InitializeComponent();
        }
        string path;
        private void button1_Click(object sender, EventArgs e)        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK){
                button2.Enabled = true;
                path = ofd.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)        {
            BinaryReader br = new BinaryReader(File.OpenRead(path));
            br.BaseStream.Position = 0x10;// in hex
            textBox1.Text = br.ReadChar().ToString();//read first character single

            //multi binary from above position
            foreach (char myChar in br.ReadChars(4)) textBox1.Text += myChar;
            br.Dispose();

            textBox1.Text = br.ReadInt16().ToString("x");//reads right to left little indian byte order
        }








    }
}
