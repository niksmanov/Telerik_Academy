using System;
using Decorator.Models;

namespace Decorator
{
    class StartUp
    {
        static void Main()
        {
            var coffee = new Coffee();
            Console.WriteLine(coffee.Print());

            var cappuccino = new Cappuccino(coffee);
            Console.WriteLine(cappuccino.Print());

            var mocha = new Mocha(coffee);
            Console.WriteLine(mocha.Print());

        }
    }
}
