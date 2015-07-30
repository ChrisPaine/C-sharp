using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml; // for xml stuff

namespace _110___Reading_xml_pt2
{
    public partial class Form1 : Form
    {
        //a way of storing data.
        //uses nodes similar as trees.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";

            if(ofd.ShowDialog()==DialogResult.OK){
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(ofd.FileName);//data from weebly site I created.
                foreach(XmlNode xn in xdoc.SelectNodes("people/person"))
                    MessageBox.Show(xdoc.SelectSingleNode("name").InnerText);//will cycle names.

                
            
            }
        }
    }
}
//example of nodes in xml
//<people> 
//    <person>
//        <name>Adam</name>
//        <Age>15</Age>
//        <Email>address@gmail.com</Email>
//    </person>
//</people>