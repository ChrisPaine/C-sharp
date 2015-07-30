using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//internal access modifier
//can only access something within the same project.

namespace _142___Internal_Access_Modifier
{
    namespace myDLL
    {
        internal class Client
        {
            internal string Name//if make the above class public and only access Name in this class.
            {
                get;
                set;
            }
            internal int Height = 25;// only accesss in project.
            public int Age
            {
                get;
                set;
            }

            public string Email
            {
                get;
                set;
            }
       
        class MyClass
        {
            void myMethod()
            {
                Client.MyClass c = new MyClass();
                //icon shows envelope in intellisense to tell you it is internal.
            }
        }
        }
    }
}
