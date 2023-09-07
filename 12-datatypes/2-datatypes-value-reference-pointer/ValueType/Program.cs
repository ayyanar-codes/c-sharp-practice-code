using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;

            Console.WriteLine(i);

            ChangeValue(i);

            Console.WriteLine(i);

            Console.ReadKey();
        }


        static void ChangeValue(int x)
        {
            x = 200;

            Console.WriteLine(x);
        }
    }
}
