using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
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
