using System;

namespace loginvalidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "adming";
            string password = "pass1234";

            string userName, userPassword;

            Console.WriteLine("enter your password:");
            userName = Console.ReadLine();
            Console.WriteLine("enter your password:");
            userPassword = Console.ReadLine();

            if (login == userName && password == userPassword);
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Oops. Something is wrong);
            }
                


        }
    }
}
