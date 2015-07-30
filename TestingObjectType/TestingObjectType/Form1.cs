using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestingObjectType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //need to verify type of objects with 'is'
            int x = 5;
            string a = "Hello";

            Mark m = new Mark();
            Dog d = new Dog();
            Cat c = new Cat();

            if(d is Dog){
                MessageBox.Show("The type is: " + d.GetType());//check types.
            }else{
                MessageBox.Show("Incorrect");
            }

        }

    }
    public class Mark
    {
        //add methods
    }

    public class Dog
    {
        //add methods
    }

    public struct Cat
    {
        //add methods
    }
}
