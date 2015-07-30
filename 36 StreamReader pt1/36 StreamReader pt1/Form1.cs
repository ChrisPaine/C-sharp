using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // for streamreader namespace is in.

// http://www.youtube.com/watch?v=--YPtMsg_6E

namespace myNamespace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            open();
        }


        public void open()
        {
        OpenFileDialog ofd = new OpenFileDialog();                              //instance of openfile dialog.

        if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {                                                                       // test condition
            StreamReader or = new StreamReader(File.OpenRead(ofd.FileName));    //instance of streamreader and path.
            textBox1.Text = or.ReadToEnd();                                     //read from the beginning didn't spec where to start.
            or.Dispose();                                                       //read from current of file to end.
                                                                                //dispose of the stream reader(close file)good practice.
                                                                                //hex editor google hxd
        }
       }
   }
}

