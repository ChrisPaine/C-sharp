using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StructExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mark m = new SMark("Hello");//lightweight value type instead of a ref type.
            m.testThis();
            
        }
    }
    public struct SMark {
        //public Mark() {
        //    MessageBox.Show("Test");
        //}
        public SMark(string x) {
            MessageBox.Show(x);
        }

        int weight;

        public void testThis() {
            MessageBox.Show("Hello");
        }
    
    }
}
