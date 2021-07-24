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
        public static string Regex_EmailId= "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public static string Regex_PhoneNumber = "^[0-9]{2}[ ][6-9][0-9]{9}$";

        public static string Regex_Password = "^((?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*-_.])(?=.{8,}))";


        public static bool ValidateFirstName(string FirstName)
        {


            return Regex.IsMatch(FirstName, Regex_FirstName);

        }

        public static void CheckFirstName(string FirstName)
        {
            if (Regex.IsMatch(FirstName, Regex_FirstName) == false)
            {
                Console.WriteLine("Entered First Name is invalid ");
                CheckFirstName(FirstName);
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
                Console.WriteLine("Entered  LastName is invalid");

            }
           

        }

        public static bool ValidateEmail(string Emailid)
        {


            return Regex.IsMatch(Emailid, Regex_EmailId);

        }
        public static void CheckEmail(string EmailId)
        {
            if (Regex.IsMatch(EmailId, Regex_EmailId) == false)
            {
                Console.WriteLine("Entered EmailId is invalid  ");

            }


        }


        public static bool ValidatePhoneNumber(string PhoneNumber)
        {
          return Regex.IsMatch(PhoneNumber, Regex_PhoneNumber);

        }
        public static void CheckNumber(string PhoneNumber)
        {
            if (Regex.IsMatch(PhoneNumber, Regex_PhoneNumber) == false)
            {
                Console.WriteLine("Entered Phone number is invalid");

            }


        }


        public static bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Password);

        }
        public static void CheckPassword(string Password)
        {
            if (Regex.IsMatch(Password, Regex_Password) == false)
            {
                Console.WriteLine(" password is invalid  enter minimum 8 characters and one Upper case and number ");

            }


        }

    }
}
