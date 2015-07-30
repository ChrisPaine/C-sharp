using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace _64___Process_Class_pt_2{
    public partial class Form1 : Form    {
        public Form1()        {            InitializeComponent();        }

        private void button1_Click(object sender, EventArgs e)        {
           foreach (Process p in Process.GetProcesses())
               MessageBox.Show(p.ProcessName);//long list

           //foreach (Process p in Process.GetProcesses()) examples
           //p.kill(); bad idea

           //foreach (Process p in Process.GetProcesses()) examples
           //MessageBox.Show(p.responding.toString());can loop thru with foreach

           foreach (Process p in Process.GetProcessesByName("skype"))
           MessageBox.Show(p.ProcessName);//by name
        }
    }
}
