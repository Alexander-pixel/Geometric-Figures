using System;

namespace Geometric_Figure
{
    public class Triangle:GeometricFigure, IPolygon
    {
        public override int GetSquare()
        {
            Check();
            int square = 0;
            int p = (_sideLength[0] + _sideLength[1] + _sideLength[2]) / 2;
            square = (int)Math.Sqrt(p * (p - _sideLength[0]) * (p - _sideLength[1]) * (p - _sideLength[2]));
            return square;
        }

        public override int GetPerimeter()
        {
            Check();
            return _sideLength[0] + _sideLength[1] + _sideLength[2];
        }

        public int Height { get; }

        public int Base
        {
            get => _sideLength[0];
        }
        public int AngleBetweenBaseAndAdjacentSide { get; }

        public int NumberOfSides
        {
            get => 3;
        }

        private int[] _sideLength = new int[3];

        private void Check()
        {
            if (_sideLength[0] + _sideLength[1] < _sideLength[2] || _sideLength[1] + _sideLength[2] < _sideLength[0] || _sideLength[0] + _sideLength[2] < _sideLength[1])
            {
                throw new NotTriangleException("You have entered wrong data for a triangle.");
            }
        }

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