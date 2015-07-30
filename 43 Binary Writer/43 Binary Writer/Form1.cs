using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;//binarywriter class

namespace _43_Binary_Writer{
    public partial class Form1 : Form    {
        public Form1()        {            InitializeComponent();  }

        string path;
        private void button1_Click(object sender, EventArgs e)        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                button2.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(path));
            short myshort = 1;
            byte[] buffer = BitConverter.GetBytes(myshort);
            Array.Reverse(buffer);//convert bytes in the wrong directions
            bw.Write('C');//write just a character.
            bw.Write(1);//write in wrong direction like before.
            bw.Dispose();
        }
    }
}
