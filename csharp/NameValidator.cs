using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NameValidator_UT_Kata
{
    public class NameValidator
    {
        private const string regex = "^[a-zA-Z0-9]+$";

        public bool ValidateUserName(string name)
        {
            if (name.Length < 6 || name.Length > 12) return false;
            // initializes the regex pattern, gives it the username, and returns true or false if they match
            return Regex.IsMatch(name, regex);
        }
    }
}
