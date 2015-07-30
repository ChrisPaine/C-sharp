using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace _111___Editing_XML_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument xDoc;
        string path;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML | *.xml";
            if(ofd.ShowDialog()==DialogResult.OK){
                path = ofd.FileName;
                xDoc = new XmlDocument();
                xDoc.Load(path);
                textBox2.Text = xDoc.SelectSingleNode("People/Person/Name").InnerText;
                numericUpDown1.Value = Convert.ToInt32(xDoc.SelectSingleNode("People/Person/Age").InnerText);
                textBox3.Text = xDoc.SelectSingleNode("People/Person/Email").InnerText;
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xDoc.SelectSingleNode("People/Person/Name").InnerText = textBox2.Text;
            xDoc.SelectSingleNode("People/Person/Age").InnerText) = numericUpDown1.Value.ToString();

        }
    }
}
