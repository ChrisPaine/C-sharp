using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Delegates_and_Events___Callbacks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class First{
            public void StartLongTask(){
                second.PerformLongTask(TaskCompleted);
            }
        public void TaskCompleted(){
            MessageBox.Show("Perform long task completed");
        }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            First f = new First();
            f.StartLongTask();
        }

    }
    public class first { 
    
    }

    public class second {
        public delegate void CallBackDelegate();

        public static void performLongTask(CallBackDelegate clientMethod)
        {
            //add code here...
            MessageBox.Show("Long running task");
            System.Threading.Thread.Sleep(3000);
            clientMethod();
        }
    }
}
