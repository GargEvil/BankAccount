﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BankAccount.WebApi.Models
{
    public partial class Address
    {
        public Address()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
