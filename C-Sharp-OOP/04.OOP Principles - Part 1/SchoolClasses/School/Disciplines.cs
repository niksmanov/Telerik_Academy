using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    internal class Disciplines
    {
        private string name;
        private uint numberOfLectures;
        private uint numberOfExercises;

        public Disciplines(string name, uint numberOfLectures, uint numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public uint NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set
            {
                this.numberOfLectures = value;
            }
        }

        public uint NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            private set
            {
                this.numberOfExercises = value;
            }
        }

        public void Print()
        {
            var print = new StringBuilder();

            print.AppendLine("Discipline: " + this.Name);
            print.AppendLine("Lecture: " + this.NumberOfLectures);
            print.AppendLine("Exercises: " + this.NumberOfExercises);

            Console.WriteLine(print.ToString());
        }

    }
}
