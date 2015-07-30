using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _102___Property_Grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Person p = new Person();
        private void button1_Click(object sender, EventArgs e)
        {
            p.Name = "Chris";
            p.Age = 20;
            p.Email = "cdpaine2003@yahoo.com";
            propertyGrid1.SelectedObject = p;
            Reload();
        }
        void Reload() {
            textBox1.Text = p.Name;
            textBox2.Text = p.Age.ToString();
            textBox3.Text = p.Email;
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            //form view click on propertygrid1 goto prop and click on events and doubleclick on propertyvaluechanged to generat this.
            Reload();//reload method

            //form view prop select 'selectedObject' choose button1 and at runtime can get propery's for button1 or any object is set.
        }
    }

    class Person {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }
    
    
    
    
    }
}
