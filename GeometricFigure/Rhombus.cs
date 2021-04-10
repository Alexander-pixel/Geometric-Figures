using System;

namespace Geometric_Figure
{
    public class Rhombus:GeometricFigure, IPolygon
    {
        public override int GetSquare()
        {
            return _sideLength[0] * Height;
        }

        public override int GetPerimeter()
        {
            return 4 * _sideLength[0];
        }

        public int Height { get; set; }

        public int Base
        {
            get => _sideLength[0];
        }
        public int AngleBetweenBaseAndAdjacentSide { get; set; }

        public int NumberOfSides
        {
            get => 4;
        }

        private int[] _sideLength = new int[1];

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