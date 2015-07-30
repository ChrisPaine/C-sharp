using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _34_OpenFileDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Image| *.png|BIK|*.bik";
            ofd.Title = "Open Image";//set properties

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                MessageBox.Show(ofd.FileName);
                MessageBox.Show(ofd.SafeFileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Image| *.png|BIK|*.bik";
            ofd.Title = "Open Image";//set properties

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);
                MessageBox.Show(ofd.SafeFileName);
            }
        }
    }
}
