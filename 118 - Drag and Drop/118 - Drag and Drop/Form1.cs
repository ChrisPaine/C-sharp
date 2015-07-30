using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _118___Drag_and_Drop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            //prop: set border
            //prop: allow drop = true
            //panel events:  dragover

            e.Effect = DragDropEffects.All;//drop any file on drop

        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            //event: dragdrop
            //cast to string array
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            foreach (string s in files)
            {
                MessageBox.Show(s);
            }
        }
    }
}
