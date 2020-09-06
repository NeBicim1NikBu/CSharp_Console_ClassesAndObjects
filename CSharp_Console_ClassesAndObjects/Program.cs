using System;

namespace CSharp_Console_ClassesAndObjects
{
    class Program
    {
        enum ShapeType
        {
            Rectangle,
            Triangle
        }
        static void Main(string[] args)
        {
            // Creating new oobjects from their classes with their own properities ( such as length or width )
            RectangleClass MyRectangle = new RectangleClass(4, 5);
            TriangleClass MyRightTriangle = new TriangleClass(3, 4);
            // Using the methods within the classes
            double AreaRect = MyRectangle.Area();
            double PerimeterRect = MyRectangle.Perimeter();
            double AreaTriangle = MyRightTriangle.Area();
            double PerimeterTriangle = MyRightTriangle.Perimeter();
            // Writing the results
            WriteResults(ShapeType.Rectangle.ToString(), MyRectangle.Width,MyRectangle.Height,AreaRect,PerimeterRect);
            WriteResults(ShapeType.Triangle.ToString(), MyRightTriangle.Width, MyRightTriangle.Height, AreaTriangle, PerimeterTriangle);
        }

        private static void WriteResults(string ShapeType, double Width, double Height,  double Area, double Perimeter)
        {
            Console.WriteLine($"---------------{ShapeType}---------------------");
            Console.WriteLine($"Area of ({Width} x {Height}) {ShapeType}\t\t: {Area}\n" +
                $"Perimeter of ({Width} x {Height}) {ShapeType}\t\t: {Perimeter}");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
