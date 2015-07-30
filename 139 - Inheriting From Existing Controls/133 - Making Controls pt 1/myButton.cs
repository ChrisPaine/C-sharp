using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


//http://www.youtube.com/watch?v=6WMT1jojpZs

namespace _133___Making_Controls_pt_1
{
    public partial class myButton : Button//inherites from usercontrol class, we want to override
    {
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (value == "Adam")
                {
                    MessageBox.Show("You are not authorized to use that name.");
                    base.Text = "Usercontrol";
                    return;
                }
                base.Text = value;
            }
        }
        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show("Test");
            base.OnClick(e);
        }
    }
}
