﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _97___Opening_Files_With_Your_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] files)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            foreach(string s in files)
                Application.Run(new Form1(s));
        }
    }
}
