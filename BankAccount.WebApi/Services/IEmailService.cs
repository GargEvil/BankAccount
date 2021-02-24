using BankAccount.WebApi.Models;

namespace BankAccount.WebApi.Services
{
    public interface IEmailService
    {
        void SendEmail(User user);
    }
}