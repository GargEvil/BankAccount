using AutoMapper;
using BankAccount.WebApi.DTO;
using BankAccount.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.WebApi.Mappers
{
    public class AutoMapping : Profile
    {
          public AutoMapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
