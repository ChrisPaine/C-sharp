using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDll.Clients;// from the dll you created will give you access to dll class.

namespace _141___Making_a_DLL
{
    //dll dynamic link library
    //put all your namespace in dll to share
    //people can't see into dll.
    //new project class library

    //create dll build and save.
    //open solution explorer and rightclick 'choose add reference'
    //will add mydll that you created to reference folder.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
