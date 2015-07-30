using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24_Throwing_an_exceptions
{
    class myClass
    {
        static Exception myException = new Exception("You can't do that!");
        public static void CheckString(string myString) { 
            if (myString == ""){
                throw myException;//usually inside of class.
            }
        
        }
    }
}
