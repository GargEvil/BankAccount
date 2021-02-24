using BankAccount.WebApi.DTO;
using BankAccount.WebApi.Models;
using System.Collections.Generic;

namespace BankAccount.WebApi.Services
{
    public interface IUserService
    {
        List<UserDTO> Get();

        User Insert(UserDTO userDto);
    }
}