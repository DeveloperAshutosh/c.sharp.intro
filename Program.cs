using System;

namespace c.sharp.intro
{
    class Program
    {
        static void Main(string[] args)
        {
    
            // Two slashes mark the beginning of a single line comment.
            // we are asigning a string value to variable.
            string myName = "Ashutosh Kaushal";
            /*we begin multi-line comments with an forward a slash and astrisk...
            Symbols between values or evaluations are considered "operators."
            Below we are using the addition symbol to concatenate two strings.
            (Concatentation means gluing two strings, or texts, together.)
            ...and we end multi-line comments with an asterisk followed by a forward-slash
            */
            Console.WriteLine("Hello, " + myName);

            //User input....
            Console.WriteLine("please enter your name...");
             // Assign variable 'userName' to a value entered by the user.
            // @link https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=netcore-3.1

            string userName = Console.ReadLine();
            // show the user that we collected the name.
            Console.WriteLine("you have entered: " + userName);
            // Instead of traditional concatenation using the addition operator...
            // We can use string interpolation (placeholders) to embed values in
            // a string!
            // @link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            Console.WriteLine("Hey {0} you are looking great today", userName);


            //lets play with string
            Console.WriteLine( "makemeuppercase".ToUpper());
            Console.WriteLine("MAKEMELOWERCASE".ToLower());
            // Substring takes two arguments: 1) Starting character position 2) Number of characters to collect
            Console.WriteLine(" ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring( 3 , 3));
            Console.WriteLine("XYZ".Length);//GET THE NUMBER OF CHARACTERS FOR THE STRING

        }
    }
}
