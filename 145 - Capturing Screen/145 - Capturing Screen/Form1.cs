using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;//for motion of images

namespace _145___Capturing_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //for single image without the threading

            Bitmap b = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);//create total capture
            Graphics g = Graphics.FromImage(b);
            g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.WorkingArea.Size);
            pictureBox1.Image = b;

        // for multi capture.
        //Thread t = new Thread(threadedCode);
        //t.Start();


        }
        //void threadedCode()
        //{
        //    for (; ; )
        //    {
        //        Bitmap b = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);//create total capture
        //        Graphics g = Graphics.FromImage(b);
        //        g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.WorkingArea.Size);
        //        pictureBox1.Image = b;
        //    }
        //}
    }
}
