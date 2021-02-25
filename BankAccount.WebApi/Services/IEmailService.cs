using BankAccount.WebApi.Models;
using System.Threading.Tasks;

namespace BankAccount.WebApi.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(User user);
    }
}