using System;

internal class Hauptklasse
{
    public enum Gender
    {
        Male,
        Female
    }

    public void MakeHuman(int humanNumber)
    {
        Human newHuman = new Human();
        newHuman.Age = humanNumber;

        if (humanNumber % 2 == 0)
        {
            newHuman.Name = "Batkata";
            newHuman.Gender = Gender.Male;
        }
        else
        {
            newHuman.Name = "Maceto";
            newHuman.Gender = Gender.Female;
        }
    }

    internal class Human
    {
        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}