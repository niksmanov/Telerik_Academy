using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using First_before_last;

namespace StudentGroups
{
    class Program
    {
        static void Main()
        {

            List<Student> students = new List<Student>();
            var studentsFromGroup2 = students.Where(x => x.GroupNumber == 2).ToList();

            //Problem 9. Student groups
            var orderedStudents = students.OrderBy(x => x.FirstName).ToList();

            //Problem 11. Extract students by email
            var studentsWithEmailInAbv = students.Where(x => x.Email.EndsWith("@abv.bg")).ToList();

            //Problem 13. Extract students by marks
            var studetnsWithAtLEastOneGrade6 = students.Where(x => x.Marks.Any(y => y.MarkValue == 6));
            var anonType =
                new
                {
                    FullName = studetnsWithAtLEastOneGrade6.Select(x => x.FirstName + " " + x.LastName),
                    Marks = studetnsWithAtLEastOneGrade6.Select(x => x.Marks)
                };

            //Problem 14. Extract students with two marks
            var studentsWith2Marks2 = students.Where(x => x.Marks.Where(y => y.MarkValue == 2).ToList().Count == 2);

            //Problem 15. Extract marks
            List<List<Marks>> allMarksOf2006Students = students.
                Where(x => x.Fn.ToString().Substring(5, 2) == "06").ToList().
                Select(x => x.Marks).ToList();

            //Problem 16.* Groups
 
            var groupedStudentsByGroupNumber = from s in students
                                               group s by s.GroupNumber into g
                                               select new { g.Key };

            // Problem 19. Grouped by GroupName extensions
            var groupedStudentsByGroupNumberWithExtensionMEthods = students.GroupBy(x => x.GroupNumber);
        }
    }
}
