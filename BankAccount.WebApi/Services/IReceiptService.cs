using BankAccount.WebApi.DTO;
using System.Collections.Generic;

namespace BankAccount.WebApi.Services
{
    public interface IReceiptService
    {
        ReceiptResponseModel GetReceiptByUserId(int userId);

    }
}