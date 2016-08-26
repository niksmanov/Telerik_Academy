using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DefiningClasses
{
    public static class PathStorage
    {

        private const string FilePath = "../../paths.txt";

        public static void SavePath(Path path)
        {
            StreamWriter writer = new StreamWriter(FilePath);
            using (writer)
            {
                writer.WriteLine(path);
            }
        }

        public static Path LoadPath()
        {
            Path path = new Path();

            StreamReader reader = new StreamReader(FilePath);
            char[] separators = { ' ', ',', ':', 'X', 'Y', 'Z' };

            using (reader)
            {
                while (true)
                {
                    string currentReadLine = reader.ReadLine();

                    if (string.IsNullOrEmpty(currentReadLine))
                    {
                        break;
                    }

                    string[] points = currentReadLine.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    double[] pointTokens = new double[points.Length];

                    for (int i = 0; i < points.Length; i++)
                    {
                        pointTokens[i] = double.Parse(points[i]);
                    }

                    Point3D point = new Point3D(pointTokens[0], pointTokens[1], pointTokens[2]);

                    path.AddPoint(point);
                }
            }
            return path;

        }

    }
}
