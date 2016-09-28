namespace Shapes.Figures
{
    using System;

    internal class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        internal override void CalculateSurface()
        {
            var surface = this.Height * this.Width;
            Console.WriteLine("Surface of rectangle is: " + surface);
        }
    }
}
