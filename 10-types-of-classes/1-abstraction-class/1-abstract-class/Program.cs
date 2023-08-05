using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_abstract_class
{


    public abstract class MathOperations
    {
        public static int AddValues(int a, int b)
        {
            int iReturnValue = 0;
            iReturnValue = a + b;
            return iReturnValue;
        }
    }


    class Program:MathOperations
    {
        static void Main(string[] args)
        {
            int AddedResult = AddValues(12, 28);
            Console.WriteLine(AddedResult);
            Console.ReadKey();
        }
    }
}
