using StudentClass.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    internal class Student : ICloneable, IComparable<Student>
    {

        public Student(string firstName, string middleName, string lastName, int ssn, string address, long mobilePhone,
            string email, string course, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public int SSN { get; private set; }
        public string Address { get; private set; }
        public long MobilePhone { get; private set; }
        public string Email { get; private set; }
        public string Course { get; private set; }
        public Specialty Specialty { get; private set; }
        public University University { get; private set; }
        public Faculty Faculty { get; private set; }


        public override bool Equals(object obj)
        {
            var objAsStudent = obj as Student;

            if (objAsStudent == null)
            {
                return false;
            }

            if (this.Specialty != objAsStudent.Specialty)
            {
                return false;
            }

            if (this.University != objAsStudent.University)
            {
                return false;
            }

            if (this.Faculty != objAsStudent.Faculty)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.SSN.GetHashCode();
        }


        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }

        public override string ToString()
        {
            var print = new StringBuilder();

            print.Append(string.Format("My name is {0} {1} {2} and I study in {3}",
                this.FirstName, this.MiddleName, this.LastName, this.University));

            return print.ToString();
        }

        public object Clone()
        {
            var clone = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address,
            this.MobilePhone, this.Email, this.Course, this.Specialty, this.University, this.Faculty);

            return clone;
        }

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName.CompareTo(otherStudent.FirstName) == 0)
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }

            return this.FirstName.CompareTo(otherStudent.FirstName);

            //If names are equal, compare to social security number
            //If names are not equal, compare to names
        }
    }
}
