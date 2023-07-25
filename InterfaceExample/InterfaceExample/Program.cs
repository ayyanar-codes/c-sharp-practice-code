using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            AllMethods allMethods = new AllMethods();
            allMethods.FirstMethod();
            allMethods.SecondMethod();
            allMethods.ThirdMethod();
            allMethods.FourthMethod();
            Console.ReadKey();
        }

        public interface iMethod1
        {
            void FirstMethod();
            int SecondMethod();
        }

        public interface iMethod2
        {
            void ThirdMethod();
            int FourthMethod();
        }

        public class AllMethods : iMethod1, iMethod2
        {
            public void FirstMethod()
            {
                Console.WriteLine("FirstMethod");
            }

            public int FourthMethod()
            {
                Console.WriteLine("FourthMethod");
                return 12;
            }

            public int SecondMethod()
            {
                Console.WriteLine("SecondMethod");
                return 12;
            }

            public void ThirdMethod()
            {
                Console.WriteLine("ThirdMethod");
            }
        }

    }
}
