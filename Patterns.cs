using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSTestAssignment
{
    public class Patterns
    {
        //UC1
        public static string RegexFirstName = "^[A-Z]{1,}[a-z]{2,}$";
        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, RegexFirstName);
        }
    }
}
