using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Student std1 = new Student();
            string sName = "Ayyanar";
            std1.StudentName = "Bill";
            std1.Id = 2;
            ChangeReferenceType(std1, sName);

            Console.WriteLine(std1.StudentName);
            Console.WriteLine(std1.Id);
            Console.WriteLine(sName);
            Console.ReadKey();
        }

        static void ChangeReferenceType(Student std2, string name)
        {
            std2.StudentName = "Steve";
            std2.Id = 22;
            name = "Ayyanar.A";
        }

        public class Student
        {
            public string StudentName { get; set; }
            public int Id { get; set; }
        }
    }
}
