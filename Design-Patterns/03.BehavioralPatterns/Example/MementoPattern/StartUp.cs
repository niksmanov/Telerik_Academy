using MementoPattern.Models;
using System;

namespace MementoPattern
{
    class StartUp
    {
        static void Main()
        {
            var originalObject = new OriginalObject("Pesho", "Peshov");
            Console.WriteLine($"Original object: {originalObject.FirstName} {originalObject.LastName}" + Environment.NewLine);

            var memento = new Memento("Pesho", "Peshov");
            Console.WriteLine($"Memento object: {memento.firstName} {memento.lastName}" + Environment.NewLine);

            Console.WriteLine("Renaming the original object...");
            originalObject.FirstName = "Ivan";
            originalObject.LastName = "Ivanov";
            Console.WriteLine($"Original object: {originalObject.FirstName} {originalObject.LastName}" + Environment.NewLine);

            Console.WriteLine("Reverting the information for original object...");
            originalObject.Revert();
            Console.WriteLine($"Original object: {originalObject.FirstName} {originalObject.LastName}");
        }
    }
}
