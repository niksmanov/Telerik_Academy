using StatePattern.Contracts;

namespace StatePattern.Models
{
    public class Person
    {
        public readonly string Name;
        public readonly int Age;
        public IMood mood;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.mood = new NormalMood();
        }

        private IMood GetMood(Person currentPerson)
        {
            return new NormalMood();
        }

        public void InitContact(Person person)
        {
            mood = GetMood(person);
        }

        public void Meet()
        {
            mood.Meet();
        }

        public void Greet()
        {
            mood.Greet();
        }

        public void Talk()
        {
            mood.Talk();
        }

        public void Flirt()
        {
            mood.Flirt();
        }

        public void Bye()
        {
            mood.Bye();
        }
    }
}
