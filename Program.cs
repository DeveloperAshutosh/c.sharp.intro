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
            // show the user that we collected the name.
            Console.WriteLine("you have entered: " + userName);
            //instead of tradional concatination using the addition operator...
            //we can use string interpolation (placeholders) to embed values 
            //in string
            Console.WriteLine("Hey {0} you are looking great today", userName);
            //lets play with string
            Console.WriteLine( "makemeuppercase".ToUpper());
            Console.WriteLine("MAKEMELOWERCASE".ToLower());
            // substrings take two arguements 1)string chracter position 2) number of
            //chracters to collect
            Console.WriteLine(" ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring( 3 , 3));
            Console.WriteLine("XYZ".Length);//GET THE NUMBER OF CHARACTERS FROM THE STRING

        }
    }
}
