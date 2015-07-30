using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myNamespace
{
    class myClass
    {
        string myString;
        public myClass(string name)// constructor
        {
            myString = name;
            Name = name;
        }
        
        public string Name
        {
            get{return myString} //now readonly
            private set; // user can only change value, set is accessor
            //value is keyword for info passed
            //set{
                //if(value=="") System.Windows.Forms.MessageBox("Checked value"):
            //}
        }

    }
}
