using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class Validation
    {
        public static string Regex_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_LastName = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_MobileNum = "^[1-9]{1}[0-9]{1}[ ][1-9]{1}[0-9]{9}$";
        public static string Regex_Password = "^(?=.*?[A-Z])[A-Za-z0-9!@#$%^&*]{8,}$";
        
        public bool ValidateFirstName(string first)
        {
            return Regex.IsMatch(first, Regex_FirstName);
        }

        public bool ValidateLastName(string last)
        {
            return Regex.IsMatch(last, Regex_LastName);
        }

        public bool ValidateMobileNum(string mobileNum)
        {
            return Regex.IsMatch(mobileNum, Regex_MobileNum);
        }

        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }

        public void Result(bool result)
        {
            if (result)
                Console.WriteLine("**Valid**");
            else
                Console.WriteLine("**InValid**");
        }
    }
}
