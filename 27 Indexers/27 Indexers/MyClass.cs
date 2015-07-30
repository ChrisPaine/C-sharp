using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _27_Indexers
{
    class MyClass
    {
        public string this[int index]{//indexer can use multi params with [int index, string test]
            get{return paine[index];}
            set{paine[index] = value;}//delete to make readonly.
        }
        string[] paine = {"Chris","Dianne","Seth" };
    }
}
