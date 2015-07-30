using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace _74___Project_1_Email_Sender_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //can use char map to get the circle for password protection.
        //https://www.iconfinder.com/  24px for email icon. download as .png


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("Need gmail account!");
                    return;
                }
                button1.Enabled = false;
                MailMessage message = new MailMessage();
                message.From = new MailAddress(textBox4.Text);
                message.Subject = textBox5.Text;
                message.Body = textBox2.Text;
                foreach (string s in textBox1.Text.Split(';'))
                    message.To.Add(s);
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(textBox4.Text, textBox3.Text);
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);
                button1.Enabled = true;
                MessageBox.Show("Mail sent!!");
            }
            catch { MessageBox.Show("Error typing message!", "Error", MessageBoxButtons.OK); }//error icon
            finally { button1.Enabled = true; }
        }
    }
}
