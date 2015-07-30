using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _176___Notified_When_Files_Change
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileSystemWatcher fsw = new FileSystemWatcher();
            fsw.Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fsw.NotifyFilter = NotifyFilters.LastWrite;
            fsw.Filter = "*.*";
            fsw.Changed += fsw_Changed;
            fsw.EnableRaisingEvents = true;
            //fsw.Renamed += fsw_Renamed; for renaming event

        }

        //void fsw_Renamed(object sender, RenamedEventArgs e) for renaming event
        //{
        //    throw new NotImplementedException();
        //}

        void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("You have saved a file."+e);
        }
    }
}
