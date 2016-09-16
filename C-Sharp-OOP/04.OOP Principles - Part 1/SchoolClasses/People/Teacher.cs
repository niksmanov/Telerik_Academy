using SchoolClasses.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    internal class Teacher : Person
    {
        private readonly List<Disciplines> disciplinesList;

        public Teacher(string firstName, string secondName) :
            base(firstName, secondName)
        {
            this.disciplinesList = new List<Disciplines>();
        }

        public void AddDiscipline(Disciplines discipline)
        {
            this.disciplinesList.Add(discipline);
        }

        public void RemoveDiscipline(Disciplines discipline)
        {
            this.disciplinesList.Remove(discipline);
        }

        public void Print()
        {
            var print = new StringBuilder();

            print.AppendLine(string.Format("Teacher name: {0} {1}", this.FirstName, this.SecondName));

            foreach (var discipline in disciplinesList)
            {
                print.AppendLine("Discipline: " + discipline.Name);
            }

            Console.WriteLine(print.ToString());
        }

    }
}
