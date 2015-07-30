using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _79___Picture_Box_and_Image_Class
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
            if(ofd.ShowDialog()==DialogResult.OK){
                //Image image = Image.FromFile(ofd.FileName);//use with image object below.
                //pictureBox1.ImageLocation = ofd.FileName;
                //pictureBox1.Image = image; //image class way.

                pictureBox1.ImageLocation = "http://www.midstateberkshire.com/images/aerospace.jpg";
            
            }
        }
    }
}
