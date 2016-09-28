namespace Shapes.Figures
{
    using System;

    internal class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        internal override void CalculateSurface()
        {
            var surface = this.Height * (this.Width / 2);
            Console.WriteLine("Surface of triangle is: " + surface);
        }
    }
}
