﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_else_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20, j = 20;

            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
            else if (i < j)
            {
                Console.WriteLine("i is less than j");
            }
            else
            {
                Console.WriteLine("i is equal to j");
            }

            Console.ReadKey();
        }
    }
}
