using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _128___Project_2_Paint_Program_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();//in constructor as soon form created.
        }
        bool canPaint = false;
        Graphics g;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            canPaint = true;
            if (drawSquare) {
                SolidBrush s = new SolidBrush(toolStripButton1.ForeColor);
                g.FillRectangle(s, e.X, e.Y, Convert.ToInt32(toolStripTextBox2.Text), Convert.ToInt32(toolStripTextBox2.Text));
                canPaint = false;
                drawSquare = false;
            }
            else if (drawRectangle) {
                SolidBrush s = new SolidBrush(toolStripButton1.ForeColor);
                g.FillRectangle(s, e.X, e.Y, Convert.ToInt32(toolStripTextBox2.Text) * 2, Convert.ToInt32(toolStripTextBox2.Text));
                canPaint = false;
                drawRectangle = false;
            }
            else if (drawCircle){
                SolidBrush s = new SolidBrush(toolStripButton1.ForeColor);
                //g.DrawEllipse(s, e.X, e.Y, 50, 50);
                canPaint = false;
                drawCircle = false;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            canPaint = false;
            prevX = null;
            prevY = null;
        }
        int? prevX = null;
        int? prevY = null;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (canPaint)
            {
                //SolidBrush s = new SolidBrush(Color.Black);
                //g.FillEllipse(s,e.X,e.Y, Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
                Pen pen = new Pen(toolStripButton1.ForeColor, float.Parse(toolStripTextBox1.Text));
                g.DrawLine(pen, new Point(prevX ?? e.X, prevY ?? e.Y), new Point(e.X, e.Y));
                prevX = e.X;
                prevY = e.Y;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                toolStripButton1.ForeColor = cd.Color;


            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                toolStripButton3.ForeColor = cd.Color;
                panel1.BackColor = cd.Color;
            }
        }
        bool drawSquare = false;
        private void squareToolStripMenuItem_Click(object sender, EventArgs e){
            drawSquare = true;
        }

        bool drawRectangle = false;
        private void rectangelToolStripMenuItem_Click(object sender, EventArgs e){
            drawRectangle = true;
        }
        bool drawCircle = false;
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] imagePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string path in imagePaths) { 
                g.DrawImage(Image.FromFile(path), new Point(0,0));
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

 

    }
}
