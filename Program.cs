using System;

namespace DAY_19_UserRegistration
{
   public  class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration ");

            string FirstName;
            Console.Write("Enter First Name : ");
            FirstName = Console.ReadLine();
            UserRegistration.CheckFirstName(FirstName);


            string LastName;
            Console.Write("Enter Last Name : ");
            LastName = Console.ReadLine();
            UserRegistration.CheckLastName(LastName);


            string EmailId;
            Console.Write("Enter  Email Id  :");
            EmailId = Console.ReadLine();
            UserRegistration.CheckEmail(EmailId);

           


            Console.ReadKey();

        }
    }
}
