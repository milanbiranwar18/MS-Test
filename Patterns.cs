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

        //UC2
        public static string RegexLastName = "^[A-Z]{1,}[a-z]{3,}$";
        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, RegexLastName);

        }

        //UC3
        public static string RegexEmail = "^[0-9a-zA-Z]+([+#%&_.][a-zA-Z0-9]+)*[@]{1}[a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, RegexEmail);                  //checking   abc.xyz @bl.co.in
        }

        //UC4
        public static string RegexMobileNumber = "^[1-9]{2}[6-9]{1}[0-9]{9}$";
        public bool validateMobileNumber(string MobileNumber)
        {
            return Regex.IsMatch(MobileNumber, RegexMobileNumber);
        }

    }
}
