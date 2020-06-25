using System;

namespace c.sharp.intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please tell us if you want to add , substract or multiply: (add/subsract/multiply");
            string userOperator = Console.ReadLine();
            //check if the user enterd add.
            if (userOperator =="add")
            {
                Console.WriteLine("Please enter the first number");
                //https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int


                int firstNum = Int32.Parse( Console.ReadLine() );

                Console.WriteLine("Please enter the second number");
                //calculate the result.

                int secondNum = Int32.Parse( Console.ReadLine() );
                int result = firstNum + secondNum ;

                Console.WriteLine("{0} +{1}={2}", firstNum ,secondNum , result );
            }
            else if( userOperator == "substract")
            {
                Console.WriteLine("Please enter the first number");
                //https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int


                int firstNum = Int32.Parse( Console.ReadLine() );

                Console.WriteLine("Please enter the second number");
                //calculate the result.

                int secondNum = Int32.Parse( Console.ReadLine() );
                int result = firstNum - secondNum ;

                Console.WriteLine("{0} - {1} = {2}", firstNum ,secondNum , result );

            }
            else if(userOperator == "multiply")
            {
                Console.WriteLine("Please enter the first number");
                //https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int


                int firstNum = Int32.Parse( Console.ReadLine() );

                Console.WriteLine("Please enter the second number");
                //calculate the result.

                int secondNum = Int32.Parse( Console.ReadLine() );
                int result = firstNum * secondNum ;

                Console.WriteLine("{0} *{1}={2}", firstNum ,secondNum , result );
            }
            else 
            {
                Console.WriteLine("invalid operator added");
            }

   
        }
    }
}
