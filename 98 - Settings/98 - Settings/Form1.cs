using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _98___Settings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //on open form.
            textBox1.Text = _98___Settings.Properties.Settings.Default.Name;
            textBox2.Text = _98___Settings.Properties.Settings.Default.Age.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1) on form view click 'Project Menu', 'Settings Properties', 'Settings' a settings tab appears '98 - Setting' name of program.
            //to save data(settings) of form.

            _98___Settings.Properties.Settings.Default.Name = textBox1.Text;
            _98___Settings.Properties.Settings.Default.Age = Convert.ToInt32(textBox2.Text);
            _98___Settings.Properties.Settings.Default.ButtonA = button1;//saving props for button settings.
            _98___Settings.Properties.Settings.Default.Save();

            //if want to save prop for button
            //no button on list but goto 'browse' on settings.
            //will give you a list of namespaces that you have set above with using.
            //http://www.youtube.com/watch?v=1-aPZWXYVbo
        }
    }
}
