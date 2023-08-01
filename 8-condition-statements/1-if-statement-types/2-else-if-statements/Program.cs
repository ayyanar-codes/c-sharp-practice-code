using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_else_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * if(condition1)
                {
                    // code block to be executed when if condition1 evaluates to true
                }
                else if(condition2)
                {
                    // code block to be executed when 
                    //      condition1 evaluates to flase
                    //      condition2 evaluates to true
                }
                else if(condition3)
                {
                    // code block to be executed when 
                    //      condition1 evaluates to flase
                    //      condition2 evaluates to false
                    //      condition3 evaluates to true
                }
             */

            int i = 10, j = 20;

            if (i == j)
            {
                Console.WriteLine("i is equal to j");
            }
            else if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
            else if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            Console.ReadKey();
        }
    }
}
