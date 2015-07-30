using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _103___Accessing_All_Controls_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accessAll(this.Controls);
            //foreach (Control c in this.Controls) 1) first run did all but,
                //c.Text = "Chris";//changes all but did not change control inside of group container.
        }
        void accessAll(Control.ControlCollection cc) {
            foreach (Control c in cc)
            {
                c.Text = "Paine";
                if (c.HasChildren) accessAll(c.Controls);//2) recursion to check for children inside group container.

            }
        }
    }
}
