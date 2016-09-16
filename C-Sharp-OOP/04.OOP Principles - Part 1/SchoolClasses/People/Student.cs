using SchoolClasses.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    internal class Student : Person
    {
        private uint classNumber;

        public Student(string firstName, string secondName, uint classNumber) :
            base(firstName, secondName)
        {
            this.ClassNumber = classNumber;
        }

        public uint ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                this.classNumber = value;
            }
        }

        public void Print()
        {
            var print = new StringBuilder();

            print.AppendLine(string.Format("Student name: {0} {1}", this.FirstName, this.SecondName));
            print.AppendLine("Class number: " + this.ClassNumber);

            Console.WriteLine(print.ToString());
        }

    }
}
