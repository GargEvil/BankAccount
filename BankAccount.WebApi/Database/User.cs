﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BankAccount.WebApi.Database
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal PhoneNumber { get; set; }
        public decimal IdentificationNumber { get; set; }
        public string EmailAddress { get; set; }
        public int? PackageId { get; set; }
        public int? AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Package Package { get; set; }
    }
}
