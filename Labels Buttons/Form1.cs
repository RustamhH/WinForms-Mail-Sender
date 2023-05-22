using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labels_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("consolebossaz@gmail.com");
            message.To.Add(new MailAddress(textBox1.Text));
            message.Subject = "Welcome";
            message.IsBodyHtml = true;
            message.Body = $"<html><body> My first WinForms project </body></html>";

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("consolebossaz@gmail.com", "tpwveajrwdjqrqsf"),
                EnableSsl = true,
            };
            smtpClient.Send(message);
        }
    }
}
