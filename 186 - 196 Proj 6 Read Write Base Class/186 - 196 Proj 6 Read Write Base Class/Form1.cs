using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //little Endian 10 9 8 7 6 5 4 3 2 1 (read from here)

        //big Endian (read)1 2 3 4 5 6 7 8 9 10 
    }
}
