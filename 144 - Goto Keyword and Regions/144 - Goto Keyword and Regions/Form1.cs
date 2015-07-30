using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _144___Goto_Keyword_and_Regions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chris = "blah";
            switch (chris)
            { 
                case "chris":
                    MessageBox.Show("Hello");//goes here last because of goto
                    break;
                default:
                    MessageBox.Show("the default.");
                    goto case "chris";
            
            }
            goto myCode;
        myCode:
            {
                MessageBox.Show("Test");
            }

            //can create regions.
            #region myRegion
            /* can hide 
             * bunch of code
             */
            #endregion

        }
    }
}
