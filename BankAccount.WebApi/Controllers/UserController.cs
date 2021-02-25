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
        public async Task<IActionResult> Get()
        {
           var users = await _service.Get();

            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(UserDTO userDto)
        {
            try
            {
                var savedUser = await _service.Insert(userDto);
                return Ok(savedUser);

            }catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            


        }
    }
}
