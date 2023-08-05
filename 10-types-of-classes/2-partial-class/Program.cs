using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_partial_class
{


    class Program
    {
        static void Main(string[] args)
        {
            SupportClass support = new SupportClass();
            support.StartProcess();
        }
    }

    public class SupportClass
    {
        public void StartProcess()
        {
            MathOperations mathOperations = new MathOperations();
            Console.WriteLine(mathOperations.AddTwoValues(12, 18));
            Console.WriteLine(mathOperations.MultiplyTwoValues(10, 5));
            Console.ReadKey();
        }
    }

    public partial class MathOperations
    {
        public int AddTwoValues(int a, int b)
        {
            return a + b;
        }
    }

    public partial class MathOperations
    {
        public int MultiplyTwoValues(int a, int b)
        {
            return a + b;
        }
    }
}
