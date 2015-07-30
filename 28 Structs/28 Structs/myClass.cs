using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myNamespace
{
    struct one { }

    struct Client : Iinter
    {                     //can't inherite from class or structs.
        public Client(string name)      //constructor in struct
        {
            Name = name;
            Age = 0;
        }
        
        public string Name;
        public int Age;
        public void ClearClientInfo() { //method in structs
            Name = "";
            Age = 0;
        }


        public string myName()
        {
            throw new NotImplementedException();
        }
    }

    interface Iinter{                   // can use structs and interfaces.
        string myName();
    }
}
