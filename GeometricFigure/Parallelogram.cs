using System;

namespace Geometric_Figure
{
    public class Parallelogram:GeometricFigure, IPolygon
    {
        public override int GetSquare()
        {
            return Base * Height;
        }

        public override int GetPerimeter()
        {
            return (_sideLength[0] + _sideLength[1]) * 2;
        }

        public int Height { get; set; }

        public int Base
        {
            get => _sideLength[0];
        }
        
        public int AngleBetweenBaseAndAdjacentSide { get; }
        public int NumberOfSides { get; }
        private int[] _sideLength = new int[2];

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