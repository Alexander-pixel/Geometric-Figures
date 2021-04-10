using System;

namespace Geometric_Figure
{
    public class Circle:GeometricFigure
    {
        public int Radius { get; set; }

        public override int GetSquare()
        {
            if (Radius < 0)
                throw new ArgumentException("You have entered data for the radius, less than 0.");
            else
                return (int)Math.Pow(Radius, 2);
        }

        public override int GetPerimeter()
        {
            if (Radius < 0)
                throw new ArgumentException("You have entered data for the radius, less than 0.");
            else
                return 2 * (int)Math.PI * Radius;
        }
        
    }
}