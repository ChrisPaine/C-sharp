using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _37_streamreader2
{
    public partial class Form1 : Form    {
        public Form1()        { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)        {

            OpenFileDialog ofd = new OpenFileDialog();                                  //instance of openfile dialog.
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)            {  // test condition

                StreamReader or = new StreamReader(File.OpenRead(ofd.FileName));        //instance of streamreader and path.
                or.BaseStream.Position = 4;                                             // set offset by checking hex editor lower left.  0x0c for C hex.
                textBox1.Text = or.BaseStream.ReadByte().ToString("x")+" ";             //keeps binary in hex display. read single bytes.
                byte[] buffer = new byte[3];
                or.BaseStream.Read(buffer, 0, 3);                                       //read three bytes to byte array
                
                                                                                        //read from the beginning didn't spec where to start.
                foreach (byte myByte in buffer)                                         // loop thru all elements of array buffer.
                    textBox1.Text += myByte.ToString("x")+ " ";

             or.Dispose();
             

            }
        }
    }
}