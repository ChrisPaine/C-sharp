using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _16_Methods_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message("Button1","Title");
        }
        void Message(string message, string title) {
            MessageBox.Show(message, title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Message("Button2","Title2");
        }
    }
}
