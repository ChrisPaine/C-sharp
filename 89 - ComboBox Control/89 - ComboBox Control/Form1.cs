using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _89___ComboBox_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //choose black arrow to edit items on form.
            if (comboBox1.Text == "Chris") { MessageBox.Show("Test"); }

            comboBox1.Items[0] = "Bob";
            comboBox1.Items.Add("Chris");
            MessageBox.Show(comboBox1.Items.Count.ToString());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("test");//event choose on form view.
        }
    }
}
