using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Console_ClassesAndObjects
{
    class RectangleClass
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public RectangleClass(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Area()
        {
            return Width * Height;
        }
        public double Perimeter()
        {
            return (Width + Height ) * 2;
        }
    }
}
