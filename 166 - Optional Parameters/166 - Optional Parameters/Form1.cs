using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _166___Optional_Parameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowMessage("Message");
            ShowMessage("Message","title");
        }
        /*
        void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }*/

        void ShowMessage(string message, string title = "Default Value", int amount = 0)//make sure optional prams come last
        {
            MessageBox.Show(message, title);
            for (int i = 0; i < amount; i++)
            {
                MessageBox.Show(message, title);
            }
        }
    }
}
