using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


//http://www.youtube.com/watch?v=6WMT1jojpZs

namespace _133___Making_Controls_pt_1
{
    public partial class myButton : UserControl//inherites from usercontrol class, we want to override
    {
        //1) project choose 'add windows forms...' and choose 'user control'
        // opens a design window.
        // size of cotrol when user drops to his form.
        //2) click view code.
        public myButton()
        {
            InitializeComponent();
        }
        //type 'override onpaint' will type out the below.
        string text = "";
        protected override void OnPaint(PaintEventArgs e)//note protected
        {
            DrawButton(Color.FromKnownColor(KnownColor.Control));
        }

        //3) do 'build' to see test label
        //set property getter setter , build to show 'buttonText' in prop
        public string buttonText {
            get { return text; }
            set { text = value; }
        }

        private void myButton_MouseHover(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R -30, Color.FromKnownColor(KnownColor.Control).R-5, 255);
            DrawButton(myColor);
        }

        void DrawButton(Color c) {
            SolidBrush s = new SolidBrush(Color.FromKnownColor(KnownColor.Control));//background color matches forecolor.
            Graphics g = this.CreateGraphics();//this refers to the control.
            g.FillRectangle(s, 0, 0, this.Width, this.Height);
            s.Color = Color.FromArgb(255, c.R - 13, c.G - 13, c.B - 13);
            //4) use math to center things.
            g.FillRectangle(s, 0, this.Height / 2, this.Width, this.Height / 2);
            PointF fpoint = new Point((this.Width / 2) - (text.Length), (this.Height / 2) - (text.Length));//to draw in center h,w.
            FontFamily ff = new FontFamily("Arial");
            Font f = new System.Drawing.Font(ff, 8);
            g.DrawString(text, f, s, fpoint);
            s.Color = Color.Black;
        }

        private void myButton_Leave(object sender, EventArgs e)
        {
            DrawButton(Color.FromKnownColor(KnownColor.Control));
        }

        private void myButton_MouseEnter(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R - 30, Color.FromKnownColor(KnownColor.Control).R - 5, 255);
            DrawButton(myColor);
        }
    }
}
