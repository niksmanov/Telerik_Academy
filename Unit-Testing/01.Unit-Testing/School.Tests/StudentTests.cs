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
    public class StudentTests
    {
        [Test]
        public void IsValidStudentName_NullStudentNames_ThrowsArgumentNullException()
        {
            string name = null;
            //string name = "Pesho";           
            uint uniqueNumber = 12345;
            var exception = Assert.Catch<ArgumentNullException>(() => new Student(name, uniqueNumber));
            StringAssert.Contains("Name can't be null!", exception.Message);
        }

        [Test]
        public void IsValidUniqueNumber_OutOfRangeUniqueNumbers_ThrowsArgumentOutOfRangeException()
        {
            string name = "Pesho";
            uint uniqueNumber = 12345;
            //uint uniqueNumber = 1234;
            Student student = new Student(name, uniqueNumber);
            bool rangeCheck = student.UniqueNumber >= 10000 && student.UniqueNumber <= 99999;
            Assert.True(rangeCheck);
        }
    }
}
