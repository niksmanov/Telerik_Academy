using StatePattern.Contracts;
using System;

namespace StatePattern.Models
{
    public class NormalMood : IMood
    {
        public NormalMood()
        {
        }

        public void Meet()
        {
            Console.WriteLine("[Tries to shake hands.]");
        }

        public void Greet()
        {
            Console.WriteLine("Hello.");
        }

        public void Talk()
        {
            Console.WriteLine("We have wonderful weather these days...");
        }

        public void Flirt()
        {
            Console.WriteLine("Do you want to go with me to cinema?");
        }

        public void Bye()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
