using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Varibale Program: ");
            Console.WriteLine();

            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y); */

            Console.WriteLine("What is your name? ");
            Console.WriteLine("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);


        }
    }
}
