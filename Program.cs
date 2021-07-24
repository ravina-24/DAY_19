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
            Console.ReadKey();

        }
    }
}
