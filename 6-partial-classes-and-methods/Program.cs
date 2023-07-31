using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_partial_classes_and_methods
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /*
     * In C#, you can split the implementation of a class, a struct, a method, or an interface in multiple .cs files using the partial keyword. 
     * The compiler will combine all the implementation from multiple .cs files when the program is compiled.
     * 
     * Rules for Partial Classe
     * 1. All the partial class definitions must be in the same assembly and namespace.
     * 2. All the parts must have the same accessibility like public or private, etc.
     * 3. If any part is declared abstract, sealed or base type then the whole class is declared of the same type.
     * 4. Different parts can have different base types and so the final class will inherit all the base types.
     * 5. The Partial modifier can only appear immediately before the keywords class, struct, or interface.
     * 6. Nested partial types are allowed.
     */

    public partial class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
    }

    public partial class Employee
    {
        //constructor
        public Employee(int id, string name)
        {
            this.EmpId = id;
            this.Name = name;
        }

        public void DisplayEmpInfo()
        {
            Console.WriteLine(this.EmpId + " " this.Name);
        }
    }

}
