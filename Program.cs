using System;

namespace c.sharp.intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter add/subtract/exit:");
           string command;
           while( (command = Console.ReadLine() ) != "exit")
           {
               int result;
               if(command == "add")
               {
                   Console.WriteLine("please enter first number to add");
                   int firstnum = int.Parse(Console.ReadLine() );
                   Console.WriteLine("please enter second number to add");
                   int secondnum = int.Parse(Console.ReadLine() );
                   result = Addition(firstnum , secondnum);
                     Console.WriteLine("the result is : {0}", result);
                   
               }
               else if(command == "subtract")
               {
                    Console.WriteLine("please enter first number to subtract");
                   int firstnum = int.Parse(Console.ReadLine() );
                   Console.WriteLine("please enter second number to subtract");
                   int secondnum = int.Parse(Console.ReadLine() );
                   result = subtraction(firstnum , secondnum);
                   Console.WriteLine("the result is : {0}", result);

               }
               else 
               {
                   Console.WriteLine("Invalid command , please try again:");
               }
               Console.WriteLine("PLease enter a another command add/subtract/exit");


           }
        }
        static int Addition(int num1 , int num2)
        {
            return num1 + num2;
        }
        static int subtraction(int num1 , int num2)
        {
            return num1 - num2;
        }
    }
}
