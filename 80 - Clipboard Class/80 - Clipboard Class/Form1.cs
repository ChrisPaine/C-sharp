using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _80___Clipboard_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "\\\\DRIVEJ\\Work\\CHRIS\\Screen Dumps\\binary.jpg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox2.Text = Clipboard.GetText();// getText() get text out of clipboard.
            pictureBox2.Image = Clipboard.GetImage();
            MessageBox.Show(Clipboard.GetData(DataFormats.rtf).ToString());
            try
            {
                Clipboard.SetText("Chris");//doesn't work thru's error
                Clipboard.SetImage(pictureBox1.Image);
                Clipboard.Clear();
            }
            catch { }
        }
    }
}
