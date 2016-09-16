using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    internal class Student : Human
    {
        private uint grade;

        public Student(string firstName, string lastName, uint grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public uint Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }


    }
}
