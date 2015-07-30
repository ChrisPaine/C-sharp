using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; //for stream reader.

namespace _38_StreamReader_pt3_Writing{

    public partial class Form1 : Form{
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();//instance of new openfile dialog.
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {// test condition
                StreamReader or = new StreamReader(File.OpenRead(ofd.FileName));//instance of new streamreader of the file.

                char c = (char)or.Peek(); // read a character at a position.  Won't change position. ()cast in char.
                char c1 = (char)or.Read(); //will change next character and advanced.
                char c2 = (char)or.Read(); //will change next character and advanced.

                MessageBox.Show(c.ToString() + ":" + c1.ToString() +":"+ c2.ToString());
                or.Dispose();

            }
        }
    }
}
