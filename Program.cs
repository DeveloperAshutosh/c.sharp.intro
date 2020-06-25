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


            Console.WriteLine("3" + "3");//33
            Console.WriteLine("3" + 3);//33
            Console.WriteLine(3 + "3");//33
            Console.WriteLine(3 + 6 + "3");//93
            //output our variable.
            Console.WriteLine( myInt); //42
            //A new assignment for existing variable.
            myInt = myInt +2;//44
            Console.WriteLine(myInt);//44

           //myInt = myInt +"2"; // we cant turn myInt into string .

            myInt++; //Thae same as typing myInt = myInt+1.
            Console.WriteLine(myInt); //45

            myInt--; //The same as typing myInt = myInt -1.
            Console.WriteLine(myInt); //44

            myInt +=3; //The same as typing myInt = myInt + 3
            Console.WriteLine(myInt); //47
            myInt -= 5; //The same as typing myInt = myInt - 5.
            Console.WriteLine(myInt); //42





    
           
        }
    }
}
