using BankAccount.WebApi.DTO;
using BankAccount.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.WebApi.Services
{
    public class ReceiptService : IReceiptService
    {
        private readonly BankAccountContext _context;


        public ReceiptService(BankAccountContext context)
        {
            _context = context;
        }

        public ReceiptResponseModel GetReceiptByUserId(int userId)
        {
            User user =_context.Users.Where(u => u.Id == userId).Single();

            _context.Addresses.ToList();
            _context.Packages.ToList();
            double discount = CheckDiscounts(user);

            ReceiptResponseModel receipt= new ReceiptResponseModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmailAddress = user.EmailAddress,
                IdentificationNumber = user.IdentificationNumber,
                Package = user.Package.Name,
                Address = user.Address.Name,
                PackagePrice = user.Package.Price,
                PriceToPay = (user.Package.Price) - discount
            };

            return receipt;
        }
        public double CheckDiscounts(User user)
        {
            int price = user.Package.Price;
            double discount = 0;

            if (user.Address.Name == "Srebrenica" || user.Address.Name == "Bratunac")
            {
                discount += user.Package.Price * 0.3;
            }
            if (DateTime.Now.Year - user.DateOfBirth.Year > 18 && DateTime.Now.Year - user.DateOfBirth.Year < 25)
            {
                discount += user.Package.Price * 0.3;
            }

            return discount;
        }
    }
}
