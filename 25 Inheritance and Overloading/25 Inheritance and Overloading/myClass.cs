using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myNamespace{
    class myClass{
        protected string Name = "Chris";                                // only inherite from public not private members.
        public int age = 45;

        public void display(string message) {
            System.Windows.Forms.MessageBox.Show(message);
        }
    }

    class mySecondClass : myClass{                                      //inherite all public members
        public string hairColor = "red";

        void MessageBoxSpecial(){
            System.Windows.Forms.MessageBox.Show(base.age.ToString());  //use base to access base class members
            base.display("hello");
        }

        //public new string Name = "Paine";                               //will use this method to replace other class.  If you can't access the other class like dll.
        public override string Name = "Dianne";                         //Same as above.
    }
}
