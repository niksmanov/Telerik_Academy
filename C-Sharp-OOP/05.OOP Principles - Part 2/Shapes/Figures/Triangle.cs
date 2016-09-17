using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        internal override void CalculateSurface()
        {
            var surface =  this.Height * (this.Width / 2);
            Console.WriteLine("Surface of triangle is: " + surface);
        }
    }
}
