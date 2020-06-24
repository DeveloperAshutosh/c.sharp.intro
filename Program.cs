using System;

namespace c.sharp.intro
{
    class Program
    {
        static void Main(string[] args)
        {
    
            // two slashes mark the beginning of single line comment.
            // we are asigning string value to variable
            string myName = "Ashutosh Kaushal";
            /*we begin multi-line comments with an forward slash and astrisk
            

            and we end our multi-line comments with an astersik and forward slash
            */
            Console.WriteLine("Hello, " + myName);
            Console.WriteLine("please enter your name...");

            // assign variable 'username to a value entered bu the user
            string userName = Console.ReadLine();
            Console.WriteLine("you have entered: " + userName);
            Console.WriteLine("Hey {0} you are looking great today", userName);

        }
    }
}
