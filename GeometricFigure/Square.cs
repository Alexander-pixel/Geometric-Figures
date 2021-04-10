using System;

namespace Geometric_Figure
{
    public class Square:GeometricFigure, IPolygon
    {
        public override int GetSquare()
        {
            return (int)Math.Pow(_sideLength[0], 2);
        }

        public override int GetPerimeter()
        {
            return 4 * _sideLength[0];
        }
        
        public int Height
        {
            get => _sideLength[0];
        }
        public int Base
        {
            get => _sideLength[0];
        }
        public int AngleBetweenBaseAndAdjacentSide
        {
            get => 90;
        }
        public int NumberOfSides
        {
            get => 4;
        }
        
        private int[] _sideLength = new int[1];

        public int this[int index]
        {
            get
            {
                return _sideLength[index];
            }
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