namespace MementoPattern.Models
{
    public class Memento
    {
        public readonly string firstName;
        public readonly string lastName;

        public Memento(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}

