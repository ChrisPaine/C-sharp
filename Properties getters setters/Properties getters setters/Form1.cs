using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Properties_getters_setters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chris c = new Chris();
            c.Weight = 25;

            MessageBox.Show(c.Weight.ToString());
        }
    }

    public class Chris {
                
        int weight;//lower case fields, private

        public int Weight {//property
            set { weight = value; }
            get { return weight; }

            //public int Weight{
                get; 
                set;}//short cut

        public int Weight{ get; set; }//type prop tab twice
        }
    
    }
}
