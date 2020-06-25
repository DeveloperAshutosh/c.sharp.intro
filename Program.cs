using System;

namespace c.sharp.intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 3;
            
            while( myNum > 0 ) //itrates loops while the condition is true.
            {
                Console.WriteLine("currents number is: {0}", myNum);
                myNum--;
            }
            /*
            for loop has three semi- colon - seprated components:
                1 assignment.
                2[Termination] condition.
                3 Interation.
            */
            for ( int i = 0; i < 6; i+=2 )
            {
                Console.WriteLine("current (for)  number is : {0}", i);

            }
            //if we want intration from a list use foreach loop
            //From Warren Uhrich to Everyone:  03:14 PM
            //https:docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in


            string [] myList = {"cat","turtle","lizard","frog","dog"};
            foreach( string listitem in myList)
            {
                Console.WriteLine(" The current item is : {0}", listitem);
            }
           
   
        }
    }
}
