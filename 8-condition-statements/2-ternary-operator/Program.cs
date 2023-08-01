using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ternary_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# includes a decision-making operator ?: which is called the conditional operator or ternary operator. 
             * It is the short form of the if else conditions.
             */
            int x = 20, y = 10;
            var result = x > y ? "x is greater than y" : "x is less than y";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
