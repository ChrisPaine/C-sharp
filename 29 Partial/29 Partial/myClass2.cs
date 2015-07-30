using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YouTube
{
    partial class myClass
    {
        public string Hair = "Brown";
        public int BirthDay = 22;

        partial void Message(string message) {
            System.Windows.Forms.MessageBox.Show(message);
        }
        //used in both partial class.
 

        public void ShowMessage(string message) {
            Message(message);
        }


    }
}
