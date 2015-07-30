using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace _112___Writing_New_XML_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextWriter xtw = new XmlTextWriter("C:\\Users\\cpaine\\Desktop\\TestFolder\\xdoc1.xml",Encoding.UTF8);
            xtw.Formatting = Formatting.Indented;
            xtw.WriteStartElement("People");
            xtw.WriteStartElement("Person");
            xtw.WriteStartElement("Name");
            xtw.WriteString(textBox1.Text);
            xtw.WriteEndElement();

            xtw.WriteStartElement("Age");
            xtw.WriteString(numericUpDown1.Value.ToString());
            xtw.WriteEndElement();

            xtw.WriteStartElement("Email");
            xtw.WriteString(textBox2.Text);
            xtw.WriteEndElement();

            xtw.WriteEndElement();
            xtw.Close();
        }
    }
}
