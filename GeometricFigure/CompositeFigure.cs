using System;

namespace Geometric_Figure
{
    public class CompositeFigure:GeometricFigure
    {
        private GeometricFigure[] _geometricFigures;

        public CompositeFigure()
        {
            _geometricFigures = new GeometricFigure[0];
        }

        public void AddFigure(GeometricFigure obj)
        {
            Array.Resize(ref _geometricFigures, _geometricFigures.Length + 1); 
            _geometricFigures[_geometricFigures.Length - 1] = obj;
        }
        
        public override int GetSquare()
        {
            int square = 0;
            for (int i = 0; i < _geometricFigures.Length; i++)
            {
                square += _geometricFigures[i].GetSquare();
            }

            return square;
        }

        public override int GetPerimeter()
        {
            int perimeter = 0;
            for (int i = 0; i < _geometricFigures.Length; i++)
            {
                perimeter += _geometricFigures[i].GetPerimeter();
            }

            return perimeter;
        }
    }
}