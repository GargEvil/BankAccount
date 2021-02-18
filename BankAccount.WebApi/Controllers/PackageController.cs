using BankAccount.WebApi.Database;
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
    public class PackageController : ControllerBase
    {
        private readonly IPackageService _service;


        public PackageController(IPackageService service)
        {
            _service = service;
        }


        [HttpGet]
        public List<Package> Get()
        {
            return _service.Get();
        }
    }
}
