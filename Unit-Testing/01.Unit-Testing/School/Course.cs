using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        private const uint StudentsCount = 30;
        private const string StudentsError = "Students in a course should be less than {0}!";
        private const string ExistedStudent = "This student already exist!";
        private const string StudentNotFound = "Student not found in this course!";

        private ICollection<Student> students;

        public Course()
        {
            this.students = new List<Student>();
        }

        public ICollection<Student> Students
        {
            get
            {
                return this.students;
            }
            protected set
            {
                this.students = value;
            }
        }

        public bool AddStudent(Student student)
        {
            if (this.Students.Count >= StudentsCount)
            {
                throw new ArgumentOutOfRangeException(string.Format(StudentsError, StudentsCount));
            }
            if (this.Students.Contains(student))
            {
                throw new ArgumentException(ExistedStudent);
            }
            this.Students.Add(student);
            return true;
        }

        public bool RemoveStudent(Student student)
        {
            if (!this.Students.Contains(student))
            {
                throw new ArgumentException(StudentNotFound);
            }
            this.Students.Remove(student);
            return true;
        }
    }
}
