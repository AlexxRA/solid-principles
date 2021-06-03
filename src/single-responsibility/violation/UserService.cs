using System;
using System.Net.Mail;

namespace solid_principles.src.single_responsibility.violation
{
    class UserService
    {
        public SmtpClient smtpClient;
        public void RegisterUser(string firstName, string lastName, string email)
        {
            if(!this.IsValidEmail(email)) 
                throw new Exception("Email not valid");

            var user = new User(firstName, lastName, email);
            this.SendEmail(new MailMessage("email@example.com", email) { Subject="Test" });  
        }

        private void SendEmail(MailMessage mailMessage)
        {
           this.smtpClient.Send(mailMessage);
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
/*
This class is not following the SRP. The methods SendEmail and IsValidEmail are not part of UserService, instead we can create an EmailService.
*/