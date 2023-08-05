using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_sealed_class
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();
            Console.WriteLine(math.AddTwoValues(12, 18));
            Console.ReadKey();
        }
    }


    public sealed class MathOperations
    {
        public int AddTwoValues(int a, int b)
        {
            return a + b;
        }
    }

}
