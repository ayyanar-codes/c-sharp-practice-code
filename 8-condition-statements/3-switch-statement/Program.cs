using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The switch statement can be used instead of if else statement when you want to test a variable against three or more conditions. 
             * Here, you will learn about the switch statement and how to use it efficiently in the C# program.
             * 
             * 
                switch(match expression/variable)
                {
                    case constant-value:
                    statement(s) to be executed;
                    break;
                    default: 
                    statement(s) to be executed;
                    break;
                }
             */

            int x = 10;

            switch (x)
            {
                case 5:
                    Console.WriteLine("Value of x is 5");
                    break;
                case 10:
                    Console.WriteLine("Value of x is 10");
                    break;
                case 15:
                    Console.WriteLine("Value of x is 15");
                    break;
                default:
                    Console.WriteLine("Unknown value");
                    break;
            }


            Console.ReadKey();
        }
    }
}
