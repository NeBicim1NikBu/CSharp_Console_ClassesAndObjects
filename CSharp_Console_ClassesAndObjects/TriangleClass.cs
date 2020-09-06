using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Console_ClassesAndObjects
{
    class TriangleClass
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public TriangleClass(double width,double height)
        {
            Width = width;
            Height = height;
        }
        public double Area()
        {
            return (Width * Height) / 2;
        }
        private double ThirdEdge()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }
        public double Perimeter()
        {
            return Width + Height + ThirdEdge();
        }
    }
}
