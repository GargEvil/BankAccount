using BankAccount.WebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankAccount.WebApi.Services
{
    public interface IAddressService
    {
        Task<IEnumerable<Address>> Get();
    }
}