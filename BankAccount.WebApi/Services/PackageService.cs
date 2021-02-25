using BankAccount.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.WebApi.Services
{
    public class PackageService : IPackageService
    {
        private readonly BankAccountContext _context;

        public PackageService(BankAccountContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Package>> Get()
        {
            return await _context.Packages.ToListAsync();
        }
    }
}
