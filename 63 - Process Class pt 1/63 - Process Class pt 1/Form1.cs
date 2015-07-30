using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace _63___Process_Class_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==DialogResult.OK){
                //Process.Start(ofd.FileName);start file clicked

                Process.Start("Notepad.exe");//should not be in the ofd block. no path it in system 32.

                Process.Start("cmd.exe");

                MessageBox.Show(Process.GetCurrentProcess().ProcessName);

                Process.GetCurrentProcess().Kill();
            
            }
        }
    }
}
