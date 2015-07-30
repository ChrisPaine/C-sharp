using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _51_Remove_and_Replace{
    public partial class Form1 : Form    {
        public Form1()        {            InitializeComponent();        }

        private void button1_Click(object sender, EventArgs e)        {
            string sentence = "Hello, my name is Chris";
            string after = sentence.Remove(0, 7);
            MessageBox.Show(after);
            
            string after2 = sentence.Remove(18);
            MessageBox.Show(after2);

            string after3 = sentence.Replace("Hello", "Hi");
            MessageBox.Show(after3);

            string after4 = sentence.Replace('a','i');
            MessageBox.Show(after4);
        }
    }
}
