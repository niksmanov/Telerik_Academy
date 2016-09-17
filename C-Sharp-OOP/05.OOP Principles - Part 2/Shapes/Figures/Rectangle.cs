using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
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
