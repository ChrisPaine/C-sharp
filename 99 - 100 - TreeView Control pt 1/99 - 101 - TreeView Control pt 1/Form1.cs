using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _99___101___TreeView_Control_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("People");
            treeView1.Nodes[0].Nodes.Add("Chris");//0 rep first node "people"
            treeView1.Nodes[0].Nodes.Add("Dianne");
            treeView1.Nodes[0].Nodes.Add("Seth");
            treeView1.Nodes.Add("Animals");
            treeView1.Nodes[1].Nodes.Add("Shadow");
            treeView1.Nodes[1].Nodes.Add("Cowboy");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("Dog");
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            removeCheckedNodes(treeView1.Nodes); 
            //treeView1.SelectedNode.Remove();
            //treeView1.Nodes.Clear();//remove all nodes.
            //2) select treeview1 on form and property's change checkbox: = true.
        }

        List<TreeNode> tnlist = new List<TreeNode>();

        void removeCheckedNodes(TreeNodeCollection tnc) {//new method for checkng & removing nodes.
            foreach (TreeNode tn in tnc)
                if (tn.Checked) tnlist.Add(tn);
                else if (tn.Nodes.Count != 0) removeCheckedNodes(tn.Nodes);//recursion recall function inside of.
            foreach (TreeNode tn in tnlist)
                treeView1.Nodes.Remove(tn);
        }
    }
}
