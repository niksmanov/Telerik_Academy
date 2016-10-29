using System;
using TemplateMethod.Models;

namespace TemplateMethod
{
    class StartUp
    {
        static void Main()
        {
            var chess = new Chess();
            var monopoly = new Monopoly();

            chess.Play();
            Console.WriteLine(Environment.NewLine + new string('=', 30) + Environment.NewLine);
            monopoly.Play();
        }
    }
}
