using System;

namespace RobertEovningar
{
    class Program
    {
        static void Main(string[] args)
        {

            if (3 < 6)
            {
                Console.WriteLine("Hello World!");
            }

            Console.WriteLine("Please write a username..");
            string name;
            string password;

            name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("Welcome");
                password = "NoPass";
            }

            else
            {
                Console.WriteLine("Please write a password..");
                password = Console.ReadLine();
            }

            Console.WriteLine("Your username is " + name + " and your password is " + password);
            Console.ReadKey();




        }
    }
}
