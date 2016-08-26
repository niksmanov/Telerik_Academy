using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Program
    {
        static void Main()
        {
            Point3D firstPoint = new Point3D(1, 2, 3);
            Point3D secondPoint = new Point3D(4, 5, 6);
            Point3D thirdPoint = new Point3D(7, 8, 9);

            Path path = new Path();

            path.AddPoints(firstPoint, secondPoint, thirdPoint);
            PathStorage.SavePath(path);

            Path readPath = PathStorage.LoadPath();

            Console.WriteLine(readPath);

        }
    }
}
