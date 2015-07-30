using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _96___NotifyIcon_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //refer to form1 class.
            notifyIcon1.ShowBalloonTip(1000,"Still Running","My Text",ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //click notify icon1 goto events click 'MouseDoubleClick' to create event.
            this.Show();
        }
    }
}
