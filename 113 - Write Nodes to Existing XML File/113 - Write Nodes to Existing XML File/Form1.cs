using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace _113___Write_Nodes_to_Existing_XML_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\cpaine\\Desktop\\TestFolder\\xdoc1.xml");

            XmlNode person = doc.CreateElement("Person");//create pearson
            XmlNode name = doc.CreateElement("Name");//create name
            name.InnerText = textBox1.Text;
            person.AppendChild(name);//add to name node

            XmlNode age = doc.CreateElement("Age");
            age.InnerText = numericUpDown1.Value.ToString();
            person.AppendChild(age);

            XmlNode email = doc.CreateElement("Email");
            email.InnerText = textBox1.Text;
            person.AppendChild(email);

            doc.DocumentElement.AppendChild(person);//add to person node
            doc.Save("C:\\Users\\cpaine\\Desktop\\TestFolder\\xdoc1.xml");
        }
    }
}
