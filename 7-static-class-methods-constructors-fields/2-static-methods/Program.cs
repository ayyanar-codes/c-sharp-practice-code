using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_static_methods
{
    /*
     * Static Members in Non-static Class:
     * The normal class (non-static class) can contain one or more static methods, fields, properties, events and other non-static members.
     * It is more practical to define a non-static class with some static members, than to declare an entire class as static.
     * 
     * Static Fields:
     * Static fields in a non-static class can be defined using the static keyword.
     * Static fields of a non-static class is shared across all the instances. So, changes done by one instance would reflect in others.
     * 
     * 
     * 
     */



    public class StopWatch
    {
        public static int NoOfInstances = 0;

        // instance constructor
        public StopWatch()
        {
            StopWatch.NoOfInstances++;
        }
    }


    

    class Program
    {
        static void Main(string[] args)
        {
            StopWatch sw1 = new StopWatch();
            StopWatch sw2 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances); //2 

            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);//4
        }
    }


    /*
     * Static Methods
     * You can define one or more static methods in a non-static class. Static methods can be called without creating an object. You cannot call static methods using an object of the non-static class.
     * The static methods can only call other static methods and access static members. You cannot access non-static members of the class in the static methods.
     * 
     */

    class Program2
    {
        static int counter = 0;
        string name2 = "Demo Program";

        static void Main(string[] args)
        {
            counter++; // can access static fields
            Display("Hello World!"); // can call static methods

            //name2 = "New Demo Program"; //Error: cannot access non-static members
            //SetRootFolder("C:\MyProgram"); //Error: cannot call non-static method
        }

        static void Display(string text)
        {
            Console.WriteLine(text);
        }

        public void SetRootFolder(string path) { }
    }


    /*
     * Rules for Static Methods:
     * 1. Static methods can be defined using the static keyword before a return type and after an access modifier.
     * 2. Static methods can be overloaded but cannot be overridden.
     * 3. Static methods can contain local static variables.
     * 4. Static methods cannot access or call non-static variables unless they are explicitly passed as parameters.
     * 
     */
}
