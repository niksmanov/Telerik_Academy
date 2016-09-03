namespace Abstraction.Figures
{
    using System;
    using Abstraction.Contracts;

    public abstract class Figure : IFigure
    {
        public abstract double CalcPerimeter();

        public abstract double CalcSurface();
    }
}
