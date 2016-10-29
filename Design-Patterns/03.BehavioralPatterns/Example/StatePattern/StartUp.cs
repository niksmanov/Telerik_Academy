using StatePattern.Models;

namespace StatePattern
{
    public class StartUp
    {
        static void Main()
        {
            Person firstPerson = new Person("Pesho", 23);
            Person secondPerson = new Person("Gosho", 18);

            firstPerson.InitContact(secondPerson);
            secondPerson.InitContact(firstPerson);
            firstPerson.Meet();
            secondPerson.Meet();
            firstPerson.Greet();
            secondPerson.Greet();
        }
    }
}
