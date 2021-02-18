using BankAccount.WebApi.DTO;
using BankAccount.WebApi.Model;
using System.Collections.Generic;

namespace BankAccount.WebApi.Services
{
    public interface IUserService
    {
        List<User> Get();

        User Insert(UserDTO userDto);
    }
}