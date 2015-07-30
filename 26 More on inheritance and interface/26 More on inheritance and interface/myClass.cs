using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNamespace
{
    class myClass  
    {
        private string name = "Chris";
        protected int age = 30;

        public virtual void showMessage(string message) {
            System.Windows.Forms.MessageBox.Show(message);
        }

        

    }
    class mySecondClass : myClass, IMyInterface
    {
        //can inherite from one base class.
        public string HairColor = "Brown";

        public override void showMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "My Title");
        }









        public void myVoid()
        {
            throw new NotImplementedException();
        }

        public void testVoid()
        {
            throw new NotImplementedException();
        }
    }



    class myThirdClass : mySecondClass {
        public string Test = "Dresden";
    }

    interface IMyInterface
    {
        void myVoid();//default public
        //can't define methods in interfaces.

        void testVoid();
    }
}
