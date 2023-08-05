using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_abstract_method
{


    public abstract class MathOperation
    {
        public int AddTwoValues(int a, int b)
        {
            return a + b;
        }

        public abstract void DisplayMessage();

    }


    class Program
    {
        static void Main(string[] args)
        {
            SupportingOperation supportingOperation = new SupportingOperation();

            supportingOperation.DisplayMessage();

        }

        
    }

    public class SupportingOperation : MathOperation
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Hello world!");
            Console.ReadKey();
        }
    }
}
