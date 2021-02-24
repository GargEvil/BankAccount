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

        public List<UserDTO> Get()
        {
           var users =_context.Users.ToList();       

            return _mapper.Map<List<UserDTO>>(users);
        }

        public User Insert(UserDTO userDto)
        {
            User user = _mapper.Map<User>(userDto);

            Address address = _context.Addresses.Where(a => a.Id == userDto.AddressId).Single();
            Package package = _context.Packages.Where(p => p.Id == userDto.PackageId).Single();
     

            _context.Users.Add(user);
            _context.SaveChanges();
           
            _emailService.SendEmail(user);

            return user;
        }

       
    }
}
