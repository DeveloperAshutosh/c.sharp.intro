using System;

namespace c.sharp.intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //'=" is assignment operator.
            //String is datatype is used for text
            string myString = "This is a string! ";
            //Integer datatypes is used for whole numbers(no decimal).
            int myInt = 42;
            //Double datatypes is used for decimal points number.
            double myDouble = 33.666;
            //Boolean datatypes is used for True - false values
            bool myBool = true ;
            //substraction operator is '-'(minus)
            Console.WriteLine(myInt - 10);//32
            //Multiplication operator is '*' (multiply)
            Console.WriteLine(myInt * 2);//84
            //division operator is '/'(division).
            Console.WriteLine(myInt / 2); //21
            //module operator is '%' (percent sign)
            Console.WriteLine(myInt % 13); //3
            //Addition operator is '+' (addition)
            //wait this is also concatination operator
            Console.WriteLine( myInt + 8 ); //50


            Console.WriteLine("3" + "3");

    
           
        }
    }
}
