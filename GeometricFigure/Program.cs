using System;
using System.IO;

namespace Geometric_Figure
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Square square = new Square();
            Circle circle = new Circle();
            EquilateralTriangle equilateralTriangle = new EquilateralTriangle();
            Triangle triangle = new Triangle();
            Parallelogram parallelogram = new Parallelogram() {Height = 4};
            Rectangle rectangle = new Rectangle();
            Rhombus rhombus = new Rhombus() {Height = 4};
            Trapezoid trapezoid = new Trapezoid() {Height = 4};
            Ellipse ellipse = new Ellipse() {SemiMajorAxisLength = 5, SemiMinorAxisLength = 7};
            CompositeFigure compositeFigure = new CompositeFigure();
            
            try
            {
                square[0] = 5;
                Console.WriteLine($"Square Square: {square.GetSquare()}");
                Console.WriteLine($"Square Perimeter: {square.GetPerimeter()}");
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                equilateralTriangle[0] = 3;
                Console.WriteLine($"Equilateral Triangle Square: {equilateralTriangle.GetSquare()}");
                Console.WriteLine($"Equilateral Triangle Perimeter: {equilateralTriangle.GetPerimeter()}");
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                rectangle[0] = 10;
                rectangle[1] = 5;
                Console.WriteLine($"Rectangle Square: {rectangle.GetSquare()}");
                Console.WriteLine($"Rectangle Perimeter: {rectangle.GetPerimeter()}");
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                circle.Radius = 5;
                Console.WriteLine($"Circle Square: {circle.GetSquare()}");
                Console.WriteLine($"Circle Perimeter: {circle.GetPerimeter()}");
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            try
            {
                triangle[0] = 5;
                triangle[1] = 7;
                triangle[2] = 10;
                Console.WriteLine($"Triangle Perimeter: {triangle.GetPerimeter()}");
                Console.WriteLine($"Triangle Square: {triangle.GetSquare()}");
                Console.WriteLine();
            }
            catch (NotTriangleException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                rhombus[0] = -5;
                Console.WriteLine($"Rhombus Perimeter: {rhombus.GetPerimeter()}");
                Console.WriteLine($"Rhombus Square: {rhombus.GetSquare()}");
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                parallelogram[0] = 8;
                parallelogram[1] = 4;
                Console.WriteLine($"Parallelogram Perimeter: {parallelogram.GetPerimeter()}");
                Console.WriteLine($"Parallelogram Square: {parallelogram.GetSquare()}");
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                trapezoid[0] = 8;
                trapezoid[1] = 4;
                trapezoid[2] = 6;
                trapezoid[3] = 5;
                Console.WriteLine($"Trapezoid Perimeter: {trapezoid.GetPerimeter()}");
                Console.WriteLine($"Trapezoid Square: {trapezoid.GetSquare()}");
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            try
            {
                Console.WriteLine($"Ellipse Perimeter: {ellipse.GetPerimeter()}");
                Console.WriteLine($"Ellipse Square: {ellipse.GetSquare()}");
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                compositeFigure.AddFigure(circle);
                compositeFigure.AddFigure(equilateralTriangle);
                compositeFigure.AddFigure(rectangle);
                compositeFigure.AddFigure(square);
                Console.WriteLine($"Composite Figure Square: {compositeFigure.GetSquare()}");
                Console.WriteLine($"Composite Figure Perimeter: {compositeFigure.GetPerimeter()}");
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}