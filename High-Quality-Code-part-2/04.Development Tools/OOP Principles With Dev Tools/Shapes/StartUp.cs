namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using Shapes.Figures;

    internal class StartUp
    {
        internal static void Main()
        {
            var listOfFigures = new List<Shape>
            {
                new Triangle(2.5, 1.5),
                new Rectangle(2.5, 1.5),
                new Square(2.5)
            };

            foreach (var figure in listOfFigures)
            {
                figure.CalculateSurface();
            }

            string github = "https://github.com/niksmanov";
            Console.WriteLine(Environment.NewLine + "Source: {0}", github);
        }
    }
}
