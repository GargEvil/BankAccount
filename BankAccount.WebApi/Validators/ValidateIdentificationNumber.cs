using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.WebApi.Validators
{
    public class ValidateIdentificationNumber : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value.ToString().Length != 13)
            {
                return false;
            }

            return true;
        }
    }
}
