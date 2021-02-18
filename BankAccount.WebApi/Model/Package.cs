﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BankAccount.WebApi.Model
{
    public partial class Package
    {
        public Package()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}