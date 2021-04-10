using System;

namespace Geometric_Figure
{
    public class Trapezoid:GeometricFigure, IPolygon
    {
        public override int GetSquare()
        {
            return (_sideLength[0] + _sideLength[2]) / 2 * Height;
        }

        public override int GetPerimeter()
        {
            return _sideLength[0] + _sideLength[1] + _sideLength[2] + _sideLength[3];
        }

        public int Height { get; set; }

        public int Base
        {
            get => _sideLength[0];
        }
        
        public int AngleBetweenBaseAndAdjacentSide { get; }

        public int NumberOfSides
        {
            get => 4;
        }
        
        private int[] _sideLength = new int[4];

        public int this[int index]
        {
            get => _sideLength[index];
            set
            {
                if(value > 0)
                    _sideLength[index] = value;
                else
                {
                    _sideLength[index] = 0;
                    throw new ArgumentException("You have entered data, less than 0");
                }
            }
        }
    }
}