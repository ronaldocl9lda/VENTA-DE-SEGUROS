using System.Net.Mail;
using System.Configuration;
using System.Net.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Text;
using System;

namespace InsuranceProgram.Layers.Persistence
{
    public class EmailSender
    {
        private string Email => "proyectoprograronaldo@gmail.com";
        private string Password => "mheczzzqzknldflm";


        public void SendEmail (StringBuilder message, DateTime date, string EmailClient)
        {
            message.Append(Environment.NewLine);
            message.Append(string.Format("\n\n\nThis email has been sent the day {0:dd/MM/yyyy} at {0:HH:mm:ss} Hrs: \n\n", date));
            message.Append(Environment.NewLine);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(this.Email);
            mail.To.Add(EmailClient);
            mail.Subject = "Billing";
            mail.Body = message.ToString();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(Email, Password);
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}
