using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myNamespace
{
    class myClass       //usefull to call multi methods.
    {
        delegate void myDelegate(string myString);//??
        public void ShowThoseMessages()
        {
            myDelegate md = new myDelegate(ShowMessage);// don't need parenth's
            md += ShowAnotherMessage ;//adding to delegate list.
            md("Chris");
        }


        void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

        void ShowAnotherMessage(string a) 
        {
           System.Windows.Forms.MessageBox.Show(a,"Test");
        }

        //void showAnotherMessage(int a)//won't work data type wrong.
        //{
        //    System.Windows.Forms.MessageBox.Show("Test");
        //}

        
    }
}
