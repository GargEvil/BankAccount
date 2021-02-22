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
        public void SendEmail(string email)
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Info-bbibank", "<your mail address>");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("User", email);
            message.To.Add(to);

            message.Subject = "Application successful";
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h1>Congratulations</h1>" +
                "<p>You successfully applicated for one of the packages in our bank</p>";

            message.Body = bodyBuilder.ToMessageBody();

            SmtpClient client = new SmtpClient();
            client.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
            client.Authenticate("<your-email-address>", "<your password>");

            client.Send(message);
            client.Disconnect(true);
            client.Dispose();
        }
    }
}
