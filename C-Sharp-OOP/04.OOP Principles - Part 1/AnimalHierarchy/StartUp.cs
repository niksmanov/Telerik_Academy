using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    internal class StartUp
    {
        internal static void CalculateAverageAge(List<IAnimal> animalsList)
        {
            decimal sumAge = 0;
            decimal count = 0;

            foreach (var animal in animalsList)
            {
                sumAge += animal.Age;
                count++;
            }

            decimal averageAge = sumAge / count;
            Console.WriteLine("Average age of animals is: {0}", averageAge);
        }


        internal static void Main()
        {
            var dogsList = new List<IAnimal>
            {
                new Dog("Sharo", 2, Gender.Male),
                new Dog("Laika", 5, Gender.Female),
                new Dog("Lipu", 7, Gender.Male)
            };

            CalculateAverageAge(dogsList);

            var kittenList = new List<IAnimal>
            {
                new Kitten("Kitty", 4),
                new Kitten("Garfilda", 3),
                new Kitten("Palechka", 1)
            };

            CalculateAverageAge(kittenList);

            var frogsList = new List<IAnimal>
            {
                new Frog("Froggy", 12, Gender.Male),
                new Frog("Djabba", 23, Gender.Male),
                new Frog("Maria", 5, Gender.Female)
            };

            //var averageAge =
            //    frogsList.Average(f => f.Age);

            var averageAge =
                (from f in frogsList
                 select f.Age)
                 .Average();

            Console.WriteLine("Average age of frogs is: " + averageAge);

        }
    }
}
