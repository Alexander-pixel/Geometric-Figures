using System;

namespace Geometric_Figure
{
    public class EquilateralTriangle:GeometricFigure, IPolygon
    {
        public int Height
        {
            get => _sideLength[0] * (int)Math.Sqrt(3) / 2;
        }

        public int Base
        {
            get => _sideLength[0];
        }

        public int AngleBetweenBaseAndAdjacentSide
        {
            get => 60;
        }

        public int NumberOfSides
        {
            get => 3;
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
        
        public override int GetSquare()
        {
            return (int)(Math.Pow(_sideLength[0], 2) * Math.Sqrt(3) / 4);
        }

        public override int GetPerimeter()
        {
            return 3 * _sideLength[0];
        }
    }
}