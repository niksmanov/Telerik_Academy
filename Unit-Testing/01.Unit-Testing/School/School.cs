using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private const string NullStudent = "Student can't be null!";
        private const string NullCourse = "Course can't be null!";

        private ICollection<Student> students;
        private ICollection<Course> courses;

        public School()
        {
            this.students = new List<Student>();
            this.courses = new List<Course>();
        }

        public ICollection<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public bool AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(NullStudent);
            }
            this.Students.Add(student);
            return true;
        }

        public bool RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(NullStudent);
            }
            this.Students.Remove(student);
            return true;
        }

        public bool AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(NullCourse);
            }
            this.Courses.Add(course);
            return true;
        }

        public bool RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(NullCourse);
            }
            this.Courses.Remove(course);
            return true;
        }
    }
}
