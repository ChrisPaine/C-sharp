using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Property_read_write_only
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mark m = new Mark();
            m.Weight = 5;
        }
    }
    public class Mark
    {
        public int Weight { get; set; }//just have a get readonly, set only write only

    }
}
