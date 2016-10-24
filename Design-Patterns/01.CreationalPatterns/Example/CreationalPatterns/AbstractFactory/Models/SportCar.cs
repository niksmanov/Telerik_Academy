using AbstractFactory.Contracts;
using System;

namespace AbstractFactory.Models
{
    public class SportCar : IEngine
    {
        public void Start()
        {
            Console.WriteLine("The sport car's engine is started!");
        }
    }
}
