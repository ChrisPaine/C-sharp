using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


//http://www.youtube.com/watch?v=2e_dvohtZGc
namespace _70___Threading_pt_2
{
    public partial class Form1 : Form//partial class here and in the also created in the designer
    {
        public Form1()
        {
            InitializeComponent();
        }

        //check the original code and the error refers to the designer.
        //Solution Explorer on the right ,double click 'Form1.Designer.cs'

        Thread t;// can call from other methods.
        //created after first error message.
        string myString = "";

        private void button1_Click(object sender, EventArgs e)
        {//other partical class in designer.
            t = new Thread(Write);
            object[] objA = {"Bob",500 };//object array to passing two params.
            t.Start(objA);//changed from last tutorial

            //created after second error message.
            //no event methods in threading.
            while (t.IsAlive) ;//isalive continue do nothing and then...
            textBox1.Text = myString;// this after thread is finished.
        }

        void Write(object array)//only pass an object,changed from last tutorial
        {
            object[] o = array as object[];//cast new object array
            for (int i = 0; i < Convert.ToInt32(o.[1]); i++){
                Thread.Sleep(50);//wait 50 milliseconds = .5 seconds
                myString += o[0].ToString() + "\r\n";//changed from last tutorial
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }

    }
}
