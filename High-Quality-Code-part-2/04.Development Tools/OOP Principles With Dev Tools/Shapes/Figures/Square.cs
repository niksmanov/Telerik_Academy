namespace Shapes.Figures
{
    using System;

    internal class Square : Shape
    {
        public Square(double height) : base(height, height)
        {
        }

        internal override void CalculateSurface()
        {
            var surface = this.Height * this.Height;

            Console.WriteLine("Surface of square is: " + surface);
        }
    }
}
