using BankAccount.WebApi.DTO;
using BankAccount.WebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankAccount.WebApi.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> Get();

        Task<User> Insert(UserDTO userDto);
    }
}