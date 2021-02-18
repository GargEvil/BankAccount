using BankAccount.WebApi.Database;
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

        public List<Package> Get()
        {
            return _context.Packages.ToList();
        }
    }
}
