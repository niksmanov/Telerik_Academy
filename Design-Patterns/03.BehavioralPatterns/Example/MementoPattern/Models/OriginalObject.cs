namespace MementoPattern.Models
{
    public class OriginalObject
    {
        private Memento memento;

        public string FirstName{ get; set; }
        public string LastName { get; set; }

        public OriginalObject(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.memento = new Memento(firstName, lastName);
        }

        public void Revert()
        {
            this.FirstName = this.memento.firstName;
            this.LastName = this.memento.lastName;
        }
    }
}

