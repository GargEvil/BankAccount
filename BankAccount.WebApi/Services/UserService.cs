using AutoMapper;
using BankAccount.WebApi.Controllers;
using BankAccount.WebApi.DTO;
using BankAccount.WebApi.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<User>> Get()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> Insert(UserDTO userDto)
        {
            User user = _mapper.Map<User>(userDto);

            Address address = await _context.Addresses.Where(a => a.Id == userDto.AddressId).SingleAsync();
            Package package = await _context.Packages.Where(p => p.Id == userDto.PackageId).SingleAsync();
     

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
           
            await _emailService.SendEmailAsync(user);

            return user;
        }

       
    }
}
