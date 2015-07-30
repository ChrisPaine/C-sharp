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

        private void button1_Click(object sender, EventArgs e) {//other partical class in designer.
            t = new Thread(Write);
            t.Start();

            //created after second error message.
            //no event methods in threading.
            while (t.IsAlive);//isalive continue do nothing and then...
            textBox1.Text = myString;// this after thread is finished.
        }

        void Write(){
            for(int i = 0;i < 1000;i++)
                myString += "Chris" + i.ToString() + "\r\n";//
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e){
            t.Abort();
        }

    }
}
