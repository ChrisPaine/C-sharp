using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Events
{
    class myClass
    {
        public event EventHandler onPropertyChanged;    //event raised when prop change.
                                                        //event just special type of delegate.
        string name = "";
        public string Name 
        {
            get { return name; }

            set { name = value;
                onPropertyChanged(this, new EventArgs());
            }
        }
    }
}
