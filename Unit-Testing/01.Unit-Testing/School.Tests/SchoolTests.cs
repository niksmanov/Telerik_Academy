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
    public class SchoolTests
    {

        [Test]
        public void IsValidStudentAddToSchool_ValidStudent_ReturnsTrue()
        {
            var school = new School();
            //bool result = school.AddStudent(null);
            bool result = school.AddStudent(new Student("Pesho", 12345));
            Assert.True(result);
        }

        [Test]
        public void IsValidStudentRemovedFromSchool_ValidStudent_ReturnsTrue()
        {
            var school = new School();
            //bool result = school.RemoveStudent(null);
            bool result = school.RemoveStudent(new Student("Pesho", 12345));
            Assert.True(result);
        }

        [Test]
        public void IsValidCourseAddToSchool_ValidCourse_ReturnsTrue()
        {
            var school = new School();
            //bool result = school.AddCourse(null);
            bool result = school.AddCourse(new Course());
            Assert.True(result);
        }

        [Test]
        public void IsValidCourseRemovedFromSchool_ValidCourse_ReturnsTrue()
        {
            var school = new School();
            //bool result = school.RemoveCourse(null);
            bool result = school.RemoveCourse(new Course());
            Assert.True(result);
        }
    }
}
