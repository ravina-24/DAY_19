using System;

namespace DAY_19_UserRegistration
{
   public  class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration ");

            //string FirstName;
            //Console.Write("Enter First Name : ");
            //FirstName = Console.ReadLine();
            //UserRegistration.CheckFirstName(FirstName);


            //string LastName;
            //Console.Write("Enter Last Name : ");
            //LastName = Console.ReadLine();
            //UserRegistration.CheckLastName(LastName);


            //string EmailId;
            //Console.Write("Enter  Email Id  :");
            //EmailId = Console.ReadLine();
            //UserRegistration.CheckEmail(EmailId);

            //string PhoneNumber;
            //Console.Write("Enter Phone Number : ");
            //PhoneNumber = Console.ReadLine();
            //UserRegistration.CheckNumber(PhoneNumber);

            string Password;
            Console.Write("Enter Password : ");
            Password = Console.ReadLine();
            UserRegistration.CheckPassword(Password);


            Console.ReadKey();

        }
    }
}
