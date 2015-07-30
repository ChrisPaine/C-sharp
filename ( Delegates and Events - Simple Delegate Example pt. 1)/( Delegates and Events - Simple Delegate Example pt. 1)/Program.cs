using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace __Delegates_and_Events___Simple_Delegate_Example_pt._1_
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
