using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _101___TreeView_pt_3_image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //1) click 'imagelist1' on form and properties 'images' and add.
            //2) image size 25,25
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 3)
            TreeNode tn = new TreeNode();
            tn.Text = "Computer";
            tn.ImageIndex = 0;
            tn.SelectedImageIndex = 0;
            treeView1.Nodes.Add(tn);

            TreeNode ta = new TreeNode();
            ta.Text = "Animal";
            ta.ImageIndex = 1;
            ta.SelectedImageIndex = 1;
            treeView1.Nodes.Add(ta);

            TreeNode tp = new TreeNode();
            tp.Text = "NX";
            tp.ImageIndex = 3;
            tp.SelectedImageIndex = 3;
            treeView1.Nodes[0].Nodes.Add(tp);

            //4) select treeview on form goto prop and imagelist choose imagelist1 to link to treeview.

        }
    }
}
