using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _82___Color_Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog()==DialogResult.OK){
                Color c = cd.Color;//color struct
                if (c.IsNamedColor) MessageBox.Show(c.Name);//get name of color, no name for custom colors.
                if (c.IsKnownColor) { MessageBox.Show(c.ToKnownColor().ToString()); }//show name of windows default colors
                //KnownColor.ActiveBorder;//enum of known colors in list

                Color co = Color.MintCream;//can set to a color.
                MessageBox.Show(co.Name);

                Color cr = Color.FromKnownColor(KnownColor.ActiveBorder);//pick color from knowncolor enum
                //MessageBox.Show(cr.Name);both works my version
                MessageBox.Show(cr.ToKnownColor().ToString());

                //color into a 32bit int, alpha, red, green, blue, gives hex or color.
                MessageBox.Show(cr.ToArgb().ToString("x")); //aabbccdd: aa = alpha, bb = red, cc = grean, dd = blue
                
                //change hex color to a color
                Color cc = Color.Black;
                int i = cc.ToArgb();
                Color b = Color.FromArgb(i);
                button1.BackColor = b;
            }
        }
    }
}
