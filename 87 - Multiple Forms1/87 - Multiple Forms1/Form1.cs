using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _87___Multiple_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;// this access this class, ismdicontainer can have forms inside of form1.
            Form2 frm2 = new Form2();
            frm2.MdiParent = this;//refers to form1 container
            frm2.Show();//not showdialog cannot use.

            Form3 Frm3 = new Form3();
            Frm3.MdiParent = this;//refers to form1 container
            Frm3.Show();//not showdialog cannot use.

            Form4 Frm4 = new Form4();//all inside form 1
            Frm4.MdiParent = this;//refers to form1 container
            Frm4.Show();//not showdialog cannot use.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //arranges minimized layout of children windows.
            this.LayoutMdi(MdiLayout.ArrangeIcons);//set all the children inside container

            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
