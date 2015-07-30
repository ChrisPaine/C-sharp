using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _83___FontDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.MinSize = 10;//set size limit.
            fd.MaxSize = 20;
            fd.ShowColor = true; // allows user to choose color.
            fd.ShowHelp = true;
            fd.HelpRequest += new EventHandler(fd_HelpRequest);//help method down below.

            if(fd.ShowDialog()==DialogResult.OK){
                textBox1.Font = fd.Font;
                textBox1.ForeColor = fd.Color;//set with fd.showcolor = true;
            
            }
        }

        void fd_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Help");
        }
    }
}
