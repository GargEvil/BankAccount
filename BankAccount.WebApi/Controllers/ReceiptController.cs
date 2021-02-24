using BankAccount.WebApi.DTO;
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
    public class ReceiptController : ControllerBase
    {
        private readonly IReceiptService _service;

        public ReceiptController(IReceiptService service)
        {
            _service = service;
        }

        [HttpGet("{userId}")]
        public ReceiptResponseModel GetByUserId(int userId)
        {
            return _service.GetReceiptByUserId(userId);
        }
    }
}
