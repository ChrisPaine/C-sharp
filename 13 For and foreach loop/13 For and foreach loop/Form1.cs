using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _13_For_and_foreach_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int inc = 0;; inc++) infinite loop 
            for (int inc = 0; inc <= 2; inc++) {
                MessageBox.Show("Hello " + inc.ToString());

                string[] names = {"Chris","Paine","Dresden" };
                foreach (string s in names) {//loops thru each of the elements
                    MessageBox.Show(s);

                    List<int> numbers = new List<int>();
                    numbers.Add(5);
                    numbers.Add(10);
                    numbers.Add(15);

                    foreach(int i in numbers){
                        MessageBox.Show(i.ToString());
                    }
                }
            }
        }
    }
}
