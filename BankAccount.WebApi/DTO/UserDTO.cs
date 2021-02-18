using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.WebApi.DTO
{
    public class UserDTO
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int PhoneNumber { get; set; }

        public int IdentificationNumber { get; set; }

        public string EmailAddress { get; set; }

        public int PackageId { get; set; }

        public int AddressId { get; set; }
    }
}
