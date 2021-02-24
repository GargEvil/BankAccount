using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.WebApi.DTO
{
    public class ReceiptResponseModel
    {     
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IdentificationNumber { get; set; }

        public string EmailAddress { get; set; }

        public string Package { get; set; }

        public string Address { get; set; }

        public int PackagePrice { get; set; }

        public double PriceToPay { get; set; }
    }
}
