using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_byte
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 255;
            //byte b2 = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'
            sbyte sb1 = -128;
            sbyte sb2 = 127;
            Console.ReadKey();
        }
    }
}
