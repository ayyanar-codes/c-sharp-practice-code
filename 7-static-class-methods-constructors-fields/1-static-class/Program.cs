using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_static_class_methods_constructors_fields
{
    

    /*
         * In C#, static means something which cannot be instantiated. You cannot create an object of a static class and cannot access static members using an object.
         * 
         * C# classes, variables, methods, properties, operators, events, and constructors can be defined as static using the static modifier keyword.
         * 
         * 
         * Static Class:
         * Apply the static modifier before the class name and after the access modifier to make a class static. The following defines a static class with static fields and methods.
         */

    public static class Calculator
    {
        private static int _resultStorage = 0;

        public static string Type = "Arithmetic";

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Store(int result)
        {
            _resultStorage = result;
        }
    }


    /*
     * Above, the Calculator class is a static. All the members of it are also static.
     * 
     * You cannot create an object of the static class; therefore the members of the static class can be accessed directly using a class name like ClassName.MemberName, as shown below.
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            var result = Calculator.Sum(10, 25); // calling static method
            Calculator.Store(result);

            var calcType = Calculator.Type; // accessing static variable
            Calculator.Type = "Scientific"; // assign value to static variable
        }
    }

    /*
     * Rules for Static Class
     * 1. Static classes cannot be instantiated.
     * 2. All the members of a static class must be static; otherwise the compiler will give an error.
     * 3. A static class can contain static variables, static methods, static properties, static operators, static events, and static constructors.
     * 4. A static class cannot contain instance members and constructors.
     * 5. Indexers and destructors cannot be static
     * 6. var cannot be used to define static members. You must specify a type of member explicitly after the static keyword.
     * 7. Static classes are sealed class and therefore, cannot be inherited.
     * 8. A static class cannot inherit from other classes.
     * 9. Static class members can be accessed using ClassName.MemberName.
     * 10. A static class remains in memory for the lifetime of the application domain in which your program resides.
     */

  
}
