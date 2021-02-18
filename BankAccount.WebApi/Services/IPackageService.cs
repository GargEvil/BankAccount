using BankAccount.WebApi.Database;
using System.Collections.Generic;

namespace BankAccount.WebApi.Services
{
    public interface IPackageService
    {
        List<Package> Get();
    }
}