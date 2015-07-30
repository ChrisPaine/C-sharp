using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media; // for sound classes

namespace _85___Playing_Sounds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //test a .wav file in player.
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==DialogResult.OK){
                SoundPlayer s = new SoundPlayer(ofd.FileName);
                s.Play();
                //s.PlayLooping();play over and over.
                s.PlaySync();// freeze your application, can move to sound stops.
                SystemSounds.Asterisk.Play();//use windows sounds
                SystemSounds.Beep.Play();
            
            
            }
        }
    }
}
