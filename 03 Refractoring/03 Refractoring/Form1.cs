using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _03_Refractoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chris m = new chris();//right click mark and choose refactor,change names of code.
            m.AddThis();
        }
    }
    public class chris {

        public void AddThis() { 
            //code
            string a = "Hello World!";//before refactor highlight code and right click choose refractor.
            MessageBox.Show(a);

            a = uslessMessageBox(a);//refracter created
        }

        private static string uslessMessageBox(string a)//refracter created
        {
            string a = "Hello World!";  //high light this line and 
            MessageBox.Show(a);         // this line then right click choose refractor 'Extracet Method'
            return a;//refracter created
        }
    }
}
