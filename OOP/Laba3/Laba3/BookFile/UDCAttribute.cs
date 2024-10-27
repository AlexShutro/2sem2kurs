using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Laba2.BookFile
{
    public class UdcAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var regex = new Regex(@"(\d{3})\.(\d{3})");
            return regex.IsMatch(value as string) == true;
        }
    }
}