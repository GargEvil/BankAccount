using AutoMapper;
using BankAccount.WebApi.DTO;
using BankAccount.WebApi.Models;
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

        public UserService(BankAccountContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<User> Get()
        {
            return _context.Users.ToList();
        }

        public User Insert(UserDTO userDto)
        {
            User user = _mapper.Map<User>(userDto);
            
             _context.Users.Add(user);
            _context.SaveChanges();


            return user;
        }
    }
}
