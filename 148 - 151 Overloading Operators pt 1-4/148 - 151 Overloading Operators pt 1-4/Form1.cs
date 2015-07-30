using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _148___151_Overloading_Operators_pt_1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item1 = new Item();
            item1.Price = 4;
            Item item2 = new Item();
            item2.Price = 6;
            Item item3 = item1 + item2;
            MessageBox.Show(item3.Price.ToString());

            //lesson 02
            Item item4 = new Item();
            item4.Price = 5;
            Item item5 = new Item();
            item5.Price = 5;
            if (item3 == item4) MessageBox.Show("equal");

            //lesson 03
            Item item8 = new Item();
            item8.Price = 3;
            Item item9 = new Item();
            item9.Price = 6;
            if (item8 > item9) MessageBox.Show("greater than");

            //lesson 04
            Item i = new Item();
            i.Price = 2;
            i++;
            MessageBox.Show(i.Price.ToString());
        }
    }
    class Item
    {
        public int Price
        {
            get;
            set;
        }
        //overload plus opperator
        public static Item operator +(Item i1, Item i2)//return type Item
        {
            Item i3 = new Item();
            i3.Price = i1.Price + i2.Price;
            return i3;
        }

        //lesson 02
        //overloading ==
        public static bool operator ==(Item i4, Item i5)
        {
            return (i4.Price == i4.Price) ? true : false;//tenary if
        }
        public static bool operator !=(Item i4, Item i5)
        {
            return (i4.Price != i5.Price) ? true : false;//tenary if
        }

        //lesson 03 overloading
        public static bool operator <(Item item8, Item item9)
        {
            return (item8.Price < item9.Price) ? true : false;
        }

        public static bool operator >(Item item8, Item item9)
        {
            return (item8.Price > item9.Price) ? true : false;
        }

        //lesson 04 overloading ++ --
        public static Item operator ++(Item item)
        {
            Item i = new Item();//can't return int so need to do below
            i.Price = item.Price + 1;
            return i;
            //didn't have to overload the -- operator
        }

        public static Item operator --(Item item)
        {
            Item i = new Item();//can't return int so need to do below
            i.Price = item.Price - 1;
            return i;

        }
}
