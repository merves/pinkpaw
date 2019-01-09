using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace Hanu.View
{
    public partial class Mail : UserControl
    {
        public Mail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("adalarveteriner@gmail.com", "NaN");
                MailMessage msg = new MailMessage();
                msg.To.Add(textBox1.Text);
                msg.From = new MailAddress("adalarveteriner@gmail.com");
                msg.Subject = textBox2.Text;
                msg.Body = textBox3.Text;
                client.Send(msg);
                MessageBox.Show("Mail send was successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Mail_Load(object sender, EventArgs e)
        {
            textBox3.Text = "Merhaba Ege bey, Köpeğiniz Kont'un 12 Haftasında ki 1. Lyme Aşısı tarihi gelmiştir. Uygun zamanınız'da Kliniğimize uğramanızı tavsiye ederiz.";
        }
    }
}
