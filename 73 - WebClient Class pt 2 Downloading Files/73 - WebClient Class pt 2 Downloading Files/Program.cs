using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _73___WebClient_Class_pt_2_Downloading_Files
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
