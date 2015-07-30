using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // for streamreader namespace is in.

namespace myNamespace
{
    class MyClass
    {
        public void open()
        {
            OpenFileDialog ofd = new OpenFileDialog();                              //instance of openfile dialog.

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {                                                                       // test condition
                StreamReader or = new StreamReader(File.OpenRead(ofd.FileName));    //instance of streamreader and path.
                //textBox1.Text = or.ReadToEnd();                                     //read from the beginning didn't spec where to start.
                or.Dispose();                                                       //read from current of file to end.
                //dispose of the stream reader(close file)good practice.
                //hex editor google hxd
            }
        }

    }
}
