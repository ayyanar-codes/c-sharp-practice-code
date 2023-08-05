using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_static_class
{
    class Program
    {
        static void Main(string[] args)
        {
            int iResult = MathOperations.AddTwoValues(12, 18);
            Console.WriteLine(iResult);
            Console.ReadKey();
        }
    }

    public static class MathOperations
    {
        public static int AddTwoValues(int a, int b)
        {
            return a + b;
        }
    }
}
