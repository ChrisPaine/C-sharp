using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _140___Splash_Screen
{
    //Classes Program.cs
    //Application.Run(new splashScreen()); change from new form1 to new splashScreen()
    //Class splashScreen.cs

    //dock picture box to form.

    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }
        Timer t;
        private void splashScreen_Shown(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 2000;
            t.Start();
            t.Tick += new EventHandler(t_Tick);
        }
        void t_Tick(object sender, EventArgs e)
        {
            t.Stop();
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
