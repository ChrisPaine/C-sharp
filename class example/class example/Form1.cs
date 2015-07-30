using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace class_example
{
    public partial class Form1 : Form//class partial
    {
        //goto solution exlorer and right click prog name, then add items new class.
        //new class seperate file.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chris c = new chris();
            c.a = 123;
        }
    }// partial class ends

    public class chris{
        public int a = 54;
    }

    class MyClass// type class and hit tab twice.
    {
        
    }
}
