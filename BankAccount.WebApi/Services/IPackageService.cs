using BankAccount.WebApi.Model;
using System.Collections.Generic;

namespace BankAccount.WebApi.Services
{
    public interface IPackageService
    {
        List<Package> Get();
    }
}