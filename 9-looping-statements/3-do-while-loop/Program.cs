using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_do_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The do while loop is the same as while loop except that it executes the code block at least once.
             
            do
            {
                //code block

            } while(condition);

            The do-while loop starts with the do keyword followed by a code block and a boolean expression with the while keyword. 
            The do while loop stops execution exits when a boolean condition evaluates to false. Because the while(condition) specified 
            at the end of the block, it certainly executes the code block at least once.

             */

            int i = 0;

            do
            {
                Console.WriteLine("i = {0}", i);
                i++;

            } while (i < 5);

            Console.ReadKey();

        }
    }
}
