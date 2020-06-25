using System;

namespace c.sharp.intro
{
    class Program
    {
        static void Main(string[] args)
        {
           // Logical operators.
           //OR will evaluate if either side is true
           Console.WriteLine(true || true); //|| is or.
           Console.WriteLine(false || true); // true
           Console.WriteLine(false || false);//false
           //AND will evaluate if both sides are true 
           Console.WriteLine(true && true); //|| is And.
           Console.WriteLine(false && true); // false.
           Console.WriteLine(false && false);//false.
           //Now does it work with diffrent datatypes.
           //Console.WriteLine(true && 1); It doesnt
           //Comparative operators...
           // Equale to check.
           Console.WriteLine( false == false );//True
           Console.WriteLine( true == false );//False
           Console.WriteLine( 2.25 ==2.25 );//True
           Console.WriteLine(2.25 == 3.14); //False
           //Console.WriteLine(3.14 == "3.14"); can not check two diff datatypes

           // greater than check.
           Console.WriteLine(6 > 7); //flase
           Console.WriteLine(10 > 5); //true
           //Less than check
           Console.WriteLine(6 > 7); //true
           Console.WriteLine(10 > 5); //false
           //Greater than or equal to check.
           Console.WriteLine(5 >= 5);//true
           Console.WriteLine(10 >= 5); //true
           Console.WriteLine(4 >= 5); //false
           //Less than and equal to check.
           Console.WriteLine(5 <= 5); //true
           Console.WriteLine(10 <= 5); //false
           Console.WriteLine(4 <= 5); //true



        }
    }
}
