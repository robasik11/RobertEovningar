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

            for (int i = 0; i < 32; i++)
            {
                Console.WriteLine("Hello World!");
            }
            Console.ReadKey();

            while (true)
            {
                Console.WriteLine("What is your password, " + name + "?");
                if (Console.ReadLine() == password)
                {
                    Console.WriteLine("Correct!");
                    break;
                    
                }
                else
                {
                    Console.WriteLine("Wrong password! try again..");


                }

            }


        }
    }
}
