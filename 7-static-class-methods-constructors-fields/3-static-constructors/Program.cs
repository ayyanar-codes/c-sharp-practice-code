using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_static_constructors
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    /*
    * Static Constructors
    * A non-static class can contain a parameterless static constructor. It can be defined with the static keyword and without access modifiers like public, private, and protected.
    * 
    * The following example demonstrates the difference between static constructor and instance constructor.
    * 
    */

    public class StopWatch
    {
        // static constructor
        static StopWatch()
        {
            Console.WriteLine("Static constructor called");
        }

        // instance constructor
        public StopWatch()
        {
            Console.WriteLine("Instance constructor called");
        }

        // static method
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }

        // instance method
        public void Start() { }

        // instance method
        public void Stop() { }
    }

    /*
     * Above, the non-static class StopWatch contains a static constructor and also a non-static constructor.
     * The static constructor is called only once whenever the static method is used or creating an instance for the first time. 
     * The following example shows that the static constructor gets called when the static method called for the first time. 
     * Calling the static method second time onwards won't call a static constructor.
     */

    /*
     * Rules for Static Constructors
     * 1. The static constructor is defined using the static keyword and without using access modifiers public, private, or protected.
     * 2. A non-static class can contain one parameterless static constructor. Parameterized static constructors are not allowed.
     * 3. Static constructor will be executed only once in the lifetime. So, you cannot determine when it will get called in an application if a class is being used at multiple places.
     * 4. A static constructor can only access static members. It cannot contain or access instance members.
     * 
     */

    /*
     * Static members are stored in a special area in the memory called High-Frequency Heap. Static members of non-static classes are shared across all the instances of the class. 
     * So, the changes done by one instance will be reflected in all the other instances.
     */
}
