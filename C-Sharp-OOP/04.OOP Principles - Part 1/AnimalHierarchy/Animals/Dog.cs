using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    internal class Dog : Animal, IAnimal, ISound
    {
        public Dog(string name, int age, Gender sex) : base(name, age, sex)
        {
        }

        public string Talk
        {
            get
            {
                return "Djaf, djaf";
            }
        }
    }
}
