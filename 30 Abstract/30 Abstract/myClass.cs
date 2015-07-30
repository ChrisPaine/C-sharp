using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myNamespace
{
    abstract class MyClass//can't delete abstract get errors.
    {
        public static string Name = "Chris";
        public static int Age = 30;

        public static void Message(string message) {
            System.Windows.Forms.MessageBox.Show(message);
        }
        public abstract void showMessage(string message);//used for overwrite derived class.
        
    }

    class mySecondClass : MyClass//will auto type, can override the abstract showMessage
    {
        public override void showMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }


    }

}
