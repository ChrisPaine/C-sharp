using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _81___ColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowHelp = true;
            cd.HelpRequest += new EventHandler(cd_HelpRequest);//+= tab twice brings up below method.

            cd.FullOpen = true;//allows default to choose custom color.
            if (cd.ShowDialog()==DialogResult.OK){
                button1.BackColor = cd.Color;
            
            
            }
        }

        void cd_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a color for the background of button");
        }
    }
}
