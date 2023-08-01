using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# provides the while loop to repeatedly execute a block of code as long as the specified condition returns true.
                While(condition)
                {
                    //code block
                }

            The while loop starts with the while keyword, and it must include a boolean conditional expression inside brackets that returns either true or false. 
            It executes the code block until the specified conditional expression returns false.

            The for loop contains the initialization and increment/decrement parts. When using the while loop, initialization should be done before the loop starts, 
            and increment or decrement steps should be inside the loop.


             */

            int i = 0; // initialization

            while (i < 10) // condition
            {
                Console.WriteLine("i = {0}", i);

                i++; // increment
            }
            Console.ReadKey();
        }
    }
}
