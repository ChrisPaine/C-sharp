using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _104___Accessing_All_Controls_pt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            accessAll(this.Controls);

        }
        void accessAll(Control.ControlCollection cc)
        {
            foreach (Control c in cc)
            {
                //c.Enabled = false;  all controls
                if (c is Button)
                {
                    Button b = c as Button;
                    b.Click += new EventHandler(b_Click);//tab tab after the += generate event handler.

                }
            
                if(c is CheckBox){
                    CheckBox ch = c as CheckBox;
                    ch.Checked = true;
                }
                if (c.HasChildren) accessAll(c.Controls);

            }
        }

        void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You click a button!");
        }
        //http://www.youtube.com/watch?v=MEu3Y5cTwZI
 
    }
}
