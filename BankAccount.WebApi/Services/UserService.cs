using AutoMapper;
using BankAccount.WebApi.Controllers;
using BankAccount.WebApi.DTO;
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
    public class UserService : IUserService
    {
        private readonly BankAccountContext _context;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;

        public UserService(BankAccountContext context, IMapper mapper, IEmailService emailService)
        {
            _context = context;
            _mapper = mapper;
            _emailService = emailService;
        }

        public List<User> Get()
        {
            return _context.Users.ToList();
        }

        public User Insert(UserDTO userDto)
        {
            
            User user = _mapper.Map<User>(userDto);

            //int discount = 0;
            //if(CheckUserYears(userDto.DateOfBirth.Year)==true)
            //{
            //    discount++;
            //}
            //if(CheckAddress(userDto.AddressId) == true)
            //{
            //    discount++;
            //}

            _context.Users.Add(user);
            _context.SaveChanges();

            _emailService.SendEmail(userDto.EmailAddress);

            return user;
        }

        public void SendMail(string email)
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Info-bbibank", "uh-ah@hotmail.com");
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
            client.Authenticate("uh-ah@hotmail.com", "monitor123");

            client.Send(message);
            client.Disconnect(true);
            client.Dispose();
        }
        //public bool CheckUserYears(int yearOfBirth)
        //{
        //    //Just simple check for discount reasons- didn't go into details (months and days)

        //    if((DateTime.Now.Year - yearOfBirth) >18 && (DateTime.Now.Year - yearOfBirth) <25 )
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //public bool CheckAddress(int addressId)
        //{
        //    //Srebrenica and Bratunac 
        //    if(addressId == 1 || addressId == 9)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
