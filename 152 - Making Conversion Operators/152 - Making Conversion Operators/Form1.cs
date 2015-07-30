using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152___Making_Conversion_Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Item i = (Item)3; //Explicit

            Item item = 3; // auto converts Implicit

            MessageBox.Show(item.Price.ToString());
        }
    }

    class Item
    {
        //explict user has to do something.
        //implict done automatic.
        public int Price
        {
            get;
            set;
        }

        //public static explicit operator Item(int itemPrice)
        //{
        //    Item i = new Item();
        //    i.Price = itemPrice;
        //    return i;
        //}

        public static implicit operator Item(int itemPrice)
        {
            Item i = new Item();
            i.Price = itemPrice;
            return i;
        }
    }
}
