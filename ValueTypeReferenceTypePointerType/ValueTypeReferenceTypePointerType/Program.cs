using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeReferenceTypePointerType
{
    class Program
    {

        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }


        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.StudentName = "Bill";

            Student std2 = std1;

            std1.StudentName = "Ayyanar";

            //ChangeReferenceType(std2);

            Console.WriteLine(std2.StudentName);
            Console.ReadKey();
        }
    }

    

    public class Student
    {
        public string StudentName { get; set; }
    }
}
