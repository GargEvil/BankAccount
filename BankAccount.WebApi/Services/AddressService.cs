using BankAccount.WebApi.Model;
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

        public List<Address> Get()
        {
            return _context.Addresses.ToList();
        }

    }
}
