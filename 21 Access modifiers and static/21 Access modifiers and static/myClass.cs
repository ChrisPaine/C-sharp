using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myNamespace
{
    class myClass
    {
        string Name;
        string lastNames;
        public myClass(string name)
        {
            Name = name;
        }
        public string name() {
            return Name;
        }

        private string lastName() {//default private access modifier.
            return lastNames;
        }

        public static void showMessage(string message){// static is modifier.
            System.Windows.Forms.MessageBox.Show(message);
        }
    }
}
