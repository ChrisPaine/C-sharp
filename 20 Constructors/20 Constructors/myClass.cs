using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myNamespace
{
    class myClass{
        string Name;
        public myClass(string name) //ctor tab twice auto constructor
        {
            //when create new class calls this method.
            Name = name;
        }
        //compiler will now which to choose base on var passed.
        public myClass(bool variable)// can have more then one contructor.
        {

        }
    }
}
