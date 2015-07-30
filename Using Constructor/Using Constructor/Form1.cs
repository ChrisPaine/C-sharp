using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Using_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mark m = new Mark("Chris");//constructor runs here.
            m.testThis();

            Mark j = new Mark();
            j.testThis();
        }

        class Mark
        {//C# makes a constructor you can see it.

            public Mark()//can overload constructors same method diff signature. j object runs this.
            {
                MessageBox.Show("Constructor: Mark runs!");
            }

            public Mark(string name)            {// overloaded constructor
                MessageBox.Show("String Mark overloaded "+name);
            }

            public Mark(string name, int weight)            {//overloaded constructor
                MessageBox.Show(name + weight.ToString());
            }


            public void testThis() {
                MessageBox.Show("Test");
            }
            
        }

    }

}
