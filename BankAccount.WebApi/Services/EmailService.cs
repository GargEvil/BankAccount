using BankAccount.WebApi.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.WebApi.Services
{
    public class EmailService : IEmailService
    {
        public void SendEmail(User user)
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Info-bbibank", "<email-address>");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("User", user.EmailAddress);
            message.To.Add(to);

            message.Subject = "Application successful";
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h1>Congratulations</h1>" +
                "<p>You successfully applied for one of the packages in our bank</p>" +
                "<p> You can review your application at this <a href=" + "http://localhost:4200/receipt/" + user.Id + "" + ">  LINK.  </a>" ;

            message.Body = bodyBuilder.ToMessageBody();

            SmtpClient client = new SmtpClient();
            client.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
            client.Authenticate("<email-address>", "<password>");

            client.Send(message);
            client.Disconnect(true);
            client.Dispose();
        }
    }
}
