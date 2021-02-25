using BankAccount.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.WebApi.Services
{
    public class AddressService : IAddressService
    {
        private readonly BankAccountContext _context;

        public AddressService(BankAccountContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Address>> Get()
        {
            return await _context.Addresses.ToListAsync();
        }

    }
}
