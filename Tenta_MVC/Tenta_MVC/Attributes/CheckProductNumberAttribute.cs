using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tenta_MVC.Attributes
{
    public class CheckProductNumberAttribute:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            var toCheck = value.ToString().ToLower();

            if (toCheck[0] != 'p' || toCheck[1] != '-') return false;
            var number = toCheck.Remove(0, 2);
            double correctNumber;
            return double.TryParse(number, out correctNumber);
        }

        public override string FormatErrorMessage(string name)
        {
            return "Product Number must be in format: p-000..., where 0 is a number";
        }
    }
}