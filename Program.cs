using System;

namespace c.sharp.intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //guid the user to enter the action
            Console.WriteLine("Please enter add/ sbstract / multiply / exit");
            string userInput;
            while ( ( userInput  = Console.ReadLine()) != "exit")//loops untill the user enter exit
            {
                int firstNum;
                int secondNum;
                int result;
                //switch is similar to if/else statement
                switch( userInput)
                {
                    //cases are used to check the specific values.
                    case "add":
                    Console.WriteLine("enter first number for addition");
                    firstNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("enter second number for addition");
                    secondNum = Int32.Parse(Console.ReadLine());
                    result = firstNum + secondNum;
                    Console.WriteLine("{0} + {1} ={2} :",firstNum,secondNum,result);

                    break;
                    case "substract":
                    Console.WriteLine("enter first number for substraction");
                    firstNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("enter second number for substraction");
                    secondNum = Int32.Parse(Console.ReadLine());
                    result = firstNum - secondNum;
                    Console.WriteLine("{0} - {1} ={2} :",firstNum,secondNum,result);
                    break;
                    case "multiply":
                    Console.WriteLine("enter first number for multiplycation");
                    firstNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("enter second number for multiplycation");
                    secondNum = Int32.Parse(Console.ReadLine());
                    result = firstNum * secondNum;
                    Console.WriteLine("{0} * {1} ={2} :",firstNum,secondNum,result);

                    break;
                    default:
                    Console.WriteLine("unrecognised operator");
                    break;


                }
                Console.WriteLine("Please enter a new command: add/sbstract/multiply");
                
            }
        }
    }
}
