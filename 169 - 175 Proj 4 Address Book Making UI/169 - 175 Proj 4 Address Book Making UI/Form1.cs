﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace _169___175_Proj_4_Address_Book_Making_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> people = new List<Person>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if(!Directory.Exists(path+"\\Address Book - Adam")){
                Directory.CreateDirectory(path + "\\Address Book - Adam");
            }
            if (!File.Exists(path + "\\Address Book - Adam\\settings.xml"))
            {
                XmlWriter xw = XmlWriter();
                
                //path + "\\Address Book - Adam\\settings.xml" ,Encoding.UTF8
                //System.Xml.XmlText
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = textBox1.Text;
            p.Email = textBox2.Text;
            p.StreetAddress = textBox3.Text;
            p.Birthday = dateTimePicker1.Value;
            p.AdditionNotes = textBox4.Text;
            people.Add(p);
            listView1.Items.Add(p.Name);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = people[listView1.SelectedItems[0].Index].Name;
            textBox2.Text = people[listView1.SelectedItems[0].Index].Email;
            textBox3.Text = people[listView1.SelectedItems[0].Index].StreetAddress;
            textBox4.Text = people[listView1.SelectedItems[0].Index].AdditionNotes;
            dateTimePicker1.Value = people[listView1.SelectedItems[0].Index].Birthday;
            listView1.SelectedItems[0].Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Remove();
        }

        void Remove()
        {
            try
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                people.RemoveAt(listView1.SelectedItems[0].Index);
            }
            catch { }//no item select catch
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            people[listView1.SelectedItems[0].Index].Name = textBox1.Text;
            people[listView1.SelectedItems[0].Index].Email = textBox2.Text;
            people[listView1.SelectedItems[0].Index].StreetAddress = textBox3.Text;
            people[listView1.SelectedItems[0].Index].AdditionNotes = textBox4.Text;
            people[listView1.SelectedItems[0].Index].Birthday = dateTimePicker1.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            xdoc.Load(path + "\\Address Book - Adam\\settings.xml");
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string AdditionNotes { get; set; }
        public DateTime Birthday { get; set; }

    }
}
