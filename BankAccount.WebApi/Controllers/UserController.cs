using BankAccount.WebApi.DTO;
using BankAccount.WebApi.Models;
using BankAccount.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _service.Get();
        }

        [HttpPost]
        public User Insert(UserDTO userDto)
        {
            return _service.Insert(userDto);
        }
    }
}
