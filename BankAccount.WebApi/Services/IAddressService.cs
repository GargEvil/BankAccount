using BankAccount.WebApi.Models;
using System.Collections.Generic;

namespace BankAccount.WebApi.Services
{
    public interface IAddressService
    {
        List<Address> Get();
    }
}