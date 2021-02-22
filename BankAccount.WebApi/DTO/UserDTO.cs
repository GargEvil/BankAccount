using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BankAccount.WebApi.Validators;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccount.WebApi.DTO
{
    public class UserDTO
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [ValidateIdentificationNumber(ErrorMessage ="Identification number should be 13 characters long (JMBG).")]
        public string IdentificationNumber { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public int PackageId { get; set; }

        [Required]
        public int AddressId { get; set; }
    }


}
