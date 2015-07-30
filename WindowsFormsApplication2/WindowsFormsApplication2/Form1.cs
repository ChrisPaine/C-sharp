using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            myClass area = new myClass(x,y);
            textBox3.Text = Convert.ToString(area.calc(x, y));
            



        }

    
    }

    public class myClass {
        public myClass(X,Y)
        {
            public int x { get; set; }
            public int y { get; set; }
        }
       
            public int calc(int x,int y){
                return x*y;
            }
      
    
    
    
    }



}
