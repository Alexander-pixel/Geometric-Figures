using System;

namespace Geometric_Figure
{
    public class Rectangle:GeometricFigure, IPolygon
    {
        public override int GetSquare()
        {
            return _sideLength[0] * _sideLength[1];
        }

        public override int GetPerimeter()
        {
            int perimeter = 0;
            for (int i = 0; i < _sideLength.Length; i++)
            {
                perimeter += _sideLength[i];
            }

            perimeter *= 2;
            return perimeter;
        }

        public int Height
        {
            get => _sideLength[0];
        }

        public int Base
        {
            get => _sideLength[1];
        }

        public int AngleBetweenBaseAndAdjacentSide
        {
            get => 90;
        }

        public int NumberOfSides
        {
            get => 4;
        }
        
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