using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _39_StreamWriter_pt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();              //open dialog
            if (ofd.ShowDialog() == DialogResult.OK)
            {                                                       //check if clicked
                button2.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(File.Create(path));  //openwrite instead create to erase file.
            sw.Write(textBox1.Text);                                // write does not add new line after write.
            sw.WriteLine("second line of text");                    // increments new line after write.
            sw.Write("Chris");                                      // another line 3.
            sw.Dispose();

        }
    }
}
