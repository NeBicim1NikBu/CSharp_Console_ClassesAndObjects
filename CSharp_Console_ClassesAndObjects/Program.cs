using System;

namespace CSharp_Console_ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating new oobjects from their classes with their own properities ( such as length or width )
            RectangleClass MyRectangle = new RectangleClass(4,5);
            TriangleClass MyRightTriangle = new TriangleClass(3, 4);
            // Using the methods within the classes
            double AreaRect= MyRectangle.Area();
            double PerimeterRect = MyRectangle.Perimeter();
            // Writing the results
            Console.WriteLine($"Area of ({MyRectangle.Width} x {MyRectangle.Height}) Rectangle\t\t: {AreaRect}\n" +
                $"Perimeter of ({MyRectangle.Width} x {MyRectangle.Height}) Rectangle\t\t: {PerimeterRect}");
            Console.WriteLine("--------------------------------------------------");
            double AreaTriangle = MyRightTriangle.Area();
            double PerimeterTriangle = MyRightTriangle.Perimeter();
            Console.WriteLine($"Area of ({MyRightTriangle.Width} x {MyRightTriangle.Height}) RightTriangle\t\t: {AreaTriangle}\n" +
                $"Perimeter of ({MyRightTriangle.Width} x {MyRightTriangle.Height}) RightTriangle\t: {PerimeterTriangle}");
        }

    }
}
