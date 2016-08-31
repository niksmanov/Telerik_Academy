namespace VariablesDataExpressionsConstants
{
    using System;

    internal class Size
    {
        private double width;
        private double height;

        internal Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            protected set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            protected set
            {
                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size size, double rotatedFigureAngle)
        {
            double width = (Math.Abs(Math.Cos(rotatedFigureAngle)) * size.width) +
                           (Math.Abs(Math.Sin(rotatedFigureAngle)) * size.height);

            double height = (Math.Abs(Math.Sin(rotatedFigureAngle)) * size.width) +
                            (Math.Abs(Math.Cos(rotatedFigureAngle)) * size.height);

            Size result = new Size(width, height);

            return result;
        }
    }
}
