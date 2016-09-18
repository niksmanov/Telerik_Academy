using StudentClass.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    internal class StartUp
    {
        internal static void Main()
        {
            var firstStudent = new Student("Ivan", "Peshov", "Goshov", 12345, "Nqkuv Adres 1", 85467892,
                "test@email.com", "first course", Specialty.Informatics, University.SofiaUniversity, Faculty.Business);

            var secondStudent = new Student("Gosho", "Ivanov", "Peshov", 123456, "Nqkuv Adres 2", 743874384,
                "test2@email.com", "second course", Specialty.InternationalBusiness, University.UNWE, Faculty.Chemistry);

            var thirdStudent = new Student("Pesho", "Goshov", "Ivanov", 1234567, "Nqkuv Adres 3", 75487545490,
                "test3@email.com", "third course", Specialty.Informatics, University.SofiaUniversity, Faculty.Business);


            Console.WriteLine(firstStudent == secondStudent); //False
            Console.WriteLine(firstStudent != secondStudent); //True

            Console.WriteLine(firstStudent == thirdStudent); //True
            Console.WriteLine(firstStudent != thirdStudent); //False

            Console.WriteLine(firstStudent.GetHashCode());
            Console.WriteLine(secondStudent.GetHashCode());
            Console.WriteLine(thirdStudent.GetHashCode());

            Console.WriteLine(firstStudent.ToString());
            Console.WriteLine(secondStudent.ToString());
            Console.WriteLine(thirdStudent.ToString());

            var clonedStudent = firstStudent.Clone();

            Console.WriteLine("First student: " + firstStudent);
            Console.WriteLine("Cloned student: " + clonedStudent);

            Console.WriteLine(firstStudent.CompareTo(secondStudent));
        }
    }
}
