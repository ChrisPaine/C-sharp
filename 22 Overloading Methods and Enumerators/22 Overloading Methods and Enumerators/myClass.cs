using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myNamespace
{
    class myClass
    {
        enum names : byte{ //defaults to integer, now it is a byte array.
            Chris, 
            Paine = 4, 
            Dianne //will now equal 5
        }

        string Name;
        public myClass(string name)// constructor
        {
            Name = name;
        }

        string name() {
            return Name;
        }

        names myNames = names.Chris;// first element defaults to 0

        public static void ShowMessage(string message) {
            System.Windows.Forms.MessageBox.Show(message);
        }
        //public static void ShowMessage(string message) create error can't have method with same parameters.
        //{
            //System.Windows.Forms.MessageBox.Show(message);
        //}

        public static void ShowMessage(int message)// overloaded as many times as you want.
        {
            System.Windows.Forms.MessageBox.Show(message.ToString());//not using namespace.
        }
    }
}
