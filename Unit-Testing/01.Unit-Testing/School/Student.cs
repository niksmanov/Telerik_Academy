using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private const string StudentName = "Name can't be null!";
        private const uint MinNumber = 10000;
        private const uint MaxNumber = 99999;
        private const string NumberRange = "Unique number must be between {0} and {1}!";

        private string name;
        private uint uniqueNumber;

        public Student(string name, uint uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                this.name = value;
                if (value == null)
                {
                    throw new ArgumentNullException(StudentName);
                }
            }
        }

        public uint UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            protected set
            {
                if (value < MinNumber || value > MaxNumber)
                {
                    throw new ArgumentOutOfRangeException(string.Format(NumberRange, MinNumber, MaxNumber));
                }
                this.uniqueNumber = value;
            }
        }

        public bool JoinCourse(Course course)
        {
            course.AddStudent(this);
            return true;
        }

        public bool LeaveCourse(Course course)
        {
            course.RemoveStudent(this);
            return true;
        }
    }
}
