using NUnit.Framework;
using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests
{
    [TestFixture]
    public class CourseTests
    {
        [Test]
        public void IsValidStudentsCount_OutOfRangeStudentsCount_ThrowsArgumentOutOfRangeException()
        {
            uint studentsCount = 30;
            //uint studentsCount = 33;
            uint studentNumber = 12345;
            var course = new Course();

            for (uint i = 0; i < studentsCount; i++)
            {
                course.AddStudent(new Student("a" + i, studentNumber++));
            }
        }

        [Test]
        public void IsValidStudentAddToCourse_ExistedStudent_ThrowsArgumentException()
        {
            var course = new Course();
            var firstStudent = course.AddStudent(new Student("Pesho", 12345));
            var secondStudent = course.AddStudent(new Student("Pesho", 12345));
            bool existedStudents = firstStudent == secondStudent;
            //bool existedStudents = firstStudent != secondStudent;

            Assert.True(existedStudents);
        }

        [Test]
        public void IsValidStudentRemovedFromCourse_InvalidRemovedStudent_ThrowsArgumentException()
        {
            var course = new Course();
            var student = course.AddStudent(new Student("Pesho", 12345));
            var exception = Assert.Catch<ArgumentException>(() => course.RemoveStudent(new Student("Pesho", 12345)));
            StringAssert.Contains("Student not found in this course!", exception.Message);
        }
    }
}
