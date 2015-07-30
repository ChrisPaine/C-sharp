#define Adam1//symbol for if statements
//#undef Adam1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _178___Preprocessor_Directives
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Chris preprocessor directive
            //code...
            #endregion

#if Adam1
            MessageBox.Show("Adam1 is defined");
#elif Bob1
            MessageBox.Show("Bob1 is defined");
#else
            MessageBox.Show("Nothing defined");
#error "adam is defined";
#endif //Adam1
        }
    }
}
