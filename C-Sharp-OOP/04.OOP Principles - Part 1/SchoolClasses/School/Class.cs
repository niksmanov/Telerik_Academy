using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    internal class Class
    {
        private readonly List<Teacher> teachersList;
        private readonly List<Student> studentsList;
        private string className;

        public Class(string className)
        {
            this.ClassName = className;
            this.teachersList = new List<Teacher>();
            this.studentsList = new List<Student>();
        }

        public string ClassName
        {
            get
            {
                return this.className;
            }
            private set
            {
                this.className = value;
            }

        }

        public void AddStudent(Student student)
        {
            this.studentsList.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachersList.Add(teacher);
        }

        public void RemoveStudent(Student student)
        {
            this.studentsList.Remove(student);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachersList.Remove(teacher);
        }

        public void Print()
        {
            var print = new StringBuilder();

            print.AppendLine(string.Format("Class name: " + this.ClassName));

            foreach (var teacher in this.teachersList)
            {
                print.AppendLine(string.Format("Teacher name: {0} {1}", teacher.FirstName, teacher.SecondName));
            }

            foreach (var student in this.studentsList)
            {
                print.AppendLine(string.Format("Student name: {0} {1}", student.FirstName, student.SecondName));
            }
            Console.WriteLine(print.ToString());
        }
    }
}
