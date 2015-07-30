using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _91___ListView_Control_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add items user enters to list.
            //hit black arrow on form view to edit columns.
            //black arrow view details to see headings.
            //multiselect to false.
            //full row select.
            //grid lines to true.

            ListViewItem lvi = new ListViewItem(textBox1.Text);
            lvi.SubItems.Add(textBox2.Text);
            lvi.SubItems.Add(textBox3.Text);
            listView1.Items.Add(lvi);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        //choose listbox got properties and choose 'ContextMenuStrip' = ContextMenuStrip1
        //context menu for right click ContextMenuStrip1 or double click
        //left click ContextMenuStrip1 and box will appear for menu items to add.
        //multi select to true now.
        
        private void getNameOfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0){
                MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);

                foreach(ListViewItem lvi in listView1.SelectedItems)
                    MessageBox.Show(lvi.SubItems[0].Text);//0 = name , 1 = age, 3 = email
            }
        }

        private void removeSelectedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //double click menu to create a event handler

            foreach (ListViewItem lvi in listView1.SelectedItems)
                lvi.Remove();
        }

        private void removeAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in listView1.Items)
                if (lvi.Checked) { lvi.Remove(); }
        }
        //add checkbox item in property's checkboxs to true.

    }
}
