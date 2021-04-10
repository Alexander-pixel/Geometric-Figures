using System;

namespace Geometric_Figure
{
    public class Ellipse:GeometricFigure
    {
        public int SemiMajorAxisLength { get; set; }
        public int SemiMinorAxisLength { get; set; }
        public override int GetSquare()
        {
            if (SemiMajorAxisLength < 0 || SemiMinorAxisLength < 0)
                throw new ArgumentException("You have entered data for the radius, less than 0.");
            else
                return SemiMajorAxisLength * SemiMinorAxisLength * (int)Math.PI;
        }

        public override int GetPerimeter()
        {
            if (SemiMajorAxisLength < 0 || SemiMinorAxisLength < 0)
                throw new ArgumentException("You have entered data for the radius, less than 0.");
            else
                return (SemiMajorAxisLength + SemiMinorAxisLength) * (int) Math.PI;
        }
    }
}