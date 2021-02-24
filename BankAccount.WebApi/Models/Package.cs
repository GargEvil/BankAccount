using System;
using System.Collections.Generic;

#nullable disable

namespace BankAccount.WebApi.Models
{
    public partial class Package
    {
        public Package()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
