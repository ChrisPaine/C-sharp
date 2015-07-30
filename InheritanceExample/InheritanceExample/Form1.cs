using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InheritanceExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal aa = new Animal();
            //only animal stuff...

            Dog a = new Dog();
            a.HWTreatment();//from dog and animal

            Cat c = new Cat();
                c.PhysicalExam();//animal
                c.HWTreatment();//dog
                c.DeClaw();//cat

        }
    }

    public class Animal
    {
        public string ownerFirstName;
        public string ownerLastName;

        public void PhysicalExam() {
            MessageBox.Show("Physical exam...");
        }
    }

    public class Dog : Animal {
        public string breed;
        public void HWTreatment() {
            MessageBox.Show("Hearworm Treatment...");        
        }
    }

        public class Cat:Dog {//can just inherite from animal base class.
            public void DeClaw() {
                MessageBox.Show("Declaw...");
            }
        
        
        
    }






}
