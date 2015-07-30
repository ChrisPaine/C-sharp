using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _121___Drawing_with_Pen_Class_pt_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
