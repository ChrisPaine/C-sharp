using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myNamespace;

namespace _28_Structs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client Client1 = new Client();
            Client1.Name = "Chris";
            Client1.Age = 35;
            MessageBox.Show(Client1.Name);
            MessageBox.Show(Client1.Age.ToString());

            Client1.ClearClientInfo();

            MessageBox.Show(Client1.Name);

            Client Client2 = new Client();
            Client2.Name = "Dianne";
            Client2.Age = 36;

            MessageBox.Show(Client2.Name);

        }
    }
}
