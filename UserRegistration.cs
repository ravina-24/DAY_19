using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY_19_UserRegistration
{
    public class UserRegistration
    {
        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";
        public static string Regex_LastName = "^[A-Z][a-z]{2,}$";
        public static bool ValidateFirstName(string FirstName)
        {


            return Regex.IsMatch(FirstName, Regex_FirstName);

        }

        public static void CheckFirstName(string FirstName)
        {
            if (Regex.IsMatch(FirstName, Regex_FirstName) == false)
            {
                Console.WriteLine("Enter valid Name in proper format ");
                
            }
            

        }

        public static bool ValidateLastName(string LastName)
        {


            return Regex.IsMatch(LastName, Regex_LastName);

        }
        public static void CheckLastName(string LastName)
        {
            if (Regex.IsMatch(LastName, Regex_LastName) == false)
            {
                Console.WriteLine("Enter valid LastName in proper format ");

            }
           

        }


    }
}
