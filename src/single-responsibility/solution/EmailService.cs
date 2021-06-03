using System;
using System.Net.Mail;

namespace solid_principles.src.single_responsibility.solution
{
    class EmailService
    {
        public SmtpClient smtpClient;

        public EmailService(SmtpClient _smtpClient)
        {
            this.smtpClient = _smtpClient;
        }

        public void SendEmail(MailMessage mailMessage)
        {
           this.smtpClient.Send(mailMessage);
        }

        public bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }
    }
}