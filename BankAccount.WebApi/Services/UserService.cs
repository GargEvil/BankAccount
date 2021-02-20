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

            return user;
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
