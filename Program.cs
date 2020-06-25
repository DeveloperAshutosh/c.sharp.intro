using System;

namespace c.sharp.intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string userInput = Console.ReadLine();
            if (userInput.Length > 0 )
            {
                Console.WriteLine("User enterd the value");
            }
            else 
            {
                Console.WriteLine("user did not enter the value");

            }

            
        }
    }
}
