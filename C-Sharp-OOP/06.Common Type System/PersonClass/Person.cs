using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    internal class Person
    {
        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public int? Age { get; private set; }

        public override string ToString()
        {
            var print = new StringBuilder();

            if (this.Age == null)
            {
                print.Append(string.Format("My name is {0} and I have no age. Maybe I'm not born yet :D", this.Name, this.Age));
            }
            else
            {
                print.Append(string.Format("My name is {0} and I'm {1} years old", this.Name, this.Age));
            }
            
            return print.ToString();
        }

    }
}
