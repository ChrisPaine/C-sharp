using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace _114___Deleting_a_XML_Node
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("C:\\Users\\cpaine\\Desktop\\TestFolder\\xdoc1.xml");

            //can change the Name to age if you want to remove nodes using age.
            foreach (XmlNode xNode in xdoc.SelectNodes("People/Person"))
                if (xNode.SelectSingleNode("Name").InnerText == textBox1.Text) xNode.ParentNode.RemoveChild(xNode);

            xdoc.Save("C:\\Users\\cpaine\\Desktop\\TestFolder\\xdoc1.xml");    
                    
                
        }
    }
}
