using System;
using System.Net.Mail;

namespace solid_principles.src.single_responsibility.solution
{
    class UserService
    {
        public EmailService emailService;

        public UserService(EmailService _emailService)
        {
            this.emailService = _emailService;
        }
        public void RegisterUser(string firstName, string lastName, string email)
        {
            if(!this.emailService.IsValidEmail(email)) 
                throw new Exception("Email not valid");

            var user = new User(firstName, lastName, email);
            this.emailService.SendEmail(new MailMessage("email@example.com", email) { Subject="Test" });  
        }
    }
}