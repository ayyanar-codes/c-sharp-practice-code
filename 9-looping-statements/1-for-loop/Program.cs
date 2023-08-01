using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The for keyword indicates a loop in C#. 
             * The for loop executes a block of statements repeatedly until the specified condition returns false.
            
            Syntax:
            for (initializer; condition; iterator)
            {
                //code block 
            }


            Initializer: 
            The initializer section is used to initialize a variable that will be local to a for loop and cannot be accessed outside loop. 
            It can also be zero or more assignment statements, method call, increment, or decrement expression e.g., ++i or i++, and await expression.

            Condition: 
            The condition is a boolean expression that will return either true or false. If an expression evaluates to true, 
            then it will execute the loop again; otherwise, the loop is exited.

            Iterator: 
            The iterator defines the incremental or decremental of the loop variable.
                
             */

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }

            Console.ReadKey();

        }
    }
}
