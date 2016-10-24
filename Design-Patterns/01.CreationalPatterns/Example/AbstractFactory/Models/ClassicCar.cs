using AbstractFactory.Contracts;
using System;

namespace AbstractFactory.Models
{
    public class ClassicCar : IEngine
    {
        public void Start()
        {
            Console.WriteLine("The classic car's engine is started!");
        }
    }
}
