using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _153___Ref_and_Out_Keywords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Age = 3;
            string name;//for the out keyword.
            Modify(ref Age, out name);//creates a new Age var, will not change, pass by value.
            MessageBox.Show(Age.ToString()+"::" + name);
               
        }
        void Modify(ref int age, out string Name)//will change both var, pass by ref.
        {
            Name = "Chris";
            age += 5;
        }
    }
}
