using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_interface
{

    interface IMath1Operations
    {
        void Math1();
    }

    interface IMath2Operations
    {
        void Math2();
    }

    public class AllConsumption : IMath1Operations, IMath2Operations
    {
        public void Math1()
        {
            Console.WriteLine("This is from first interface");
        }

        public void Math2()
        {
            Console.WriteLine("This is from 2nd interface");
        }

        public void ClassMethod()
        {
            Console.WriteLine("This is from Parent class");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Supporting supporting = new Supporting();
            supporting.StartProcess();
        }
    }

    public class Supporting
    {
        public void StartProcess()
        {
            AllConsumption allConsumption = new AllConsumption();
            allConsumption.Math1();
            allConsumption.Math2();
            allConsumption.ClassMethod();
            Console.ReadKey();
        }
    }
}
