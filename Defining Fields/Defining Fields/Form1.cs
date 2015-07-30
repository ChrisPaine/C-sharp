using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Defining_Fields
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mark m = new Mark();
            m.Weight = 5;//instance level fields

            Mark n = new Mark();
            n.Weight = 6;
        }
    }

    public class Mark {
        public int Weight;//instance level fields

        //default private
        int age = 100;//declare field = field initializer
        int a;
        int b = 25; //or int a, b = 25; a is 0 (implicit).
    }

}
