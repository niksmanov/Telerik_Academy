using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    internal class School
    {
        internal static void Main()
        {
            var firstStudent = new Student("Gosho", "Goshov", 1234);
            var secondStudent = new Student("Ivan", "Ivanov", 123456);
            var thirdStudent = new Student("Pesho", "Peshov", 12345678);

            var firstDiscipline = new Disciplines("Math", 12, 36);
            var secondDiscipline = new Disciplines("English", 28, 56);
            var thirdDiscipline = new Disciplines("Biology", 4, 12);

            var firstTeacher = new Teacher("Ginka", "Ginkova");
            var secondTeacher = new Teacher("Manol", "Manolov");
            var thirdTeacher = new Teacher("Grisho", "Grishov");

            var firstClass = new Class("XII A");
            var secondClass = new Class("VI B");
            var thirdClass = new Class("III D");

            firstTeacher.AddDiscipline(firstDiscipline);
            firstTeacher.AddDiscipline(secondDiscipline);
            firstTeacher.AddDiscipline(thirdDiscipline);

            firstClass.AddStudent(firstStudent);
            firstClass.AddTeacher(firstTeacher);


            //Prints//
            firstStudent.Print();

            firstDiscipline.Print();

            firstTeacher.Print();

            firstClass.Print();
        }
    }
}
