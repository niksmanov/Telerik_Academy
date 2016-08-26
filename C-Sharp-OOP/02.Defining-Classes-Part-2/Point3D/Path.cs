using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Path
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public List<Point3D> Points
        {
            get
            {
                return this.points;
            }
            set
            {
                this.points = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void AddPoints(params Point3D[] points)
        {
            this.points.AddRange(points);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.points);
        }
    }
}
