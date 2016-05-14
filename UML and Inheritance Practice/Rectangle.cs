using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_and_Inheritance_Practice
{
    class Rectangle:Shape
    {
        private int Length { get; set; } = 11;
        private int Width { get; set; } = 6;
        private int Result { get; set; }

        public override void GetArea()
        {
             Result = Width * Length;
        }
        public override void toString()
        {
            GetArea();
            Console.WriteLine($"The area of a rectangle is {Result}");
        }

        public Rectangle()
        {

        }
    }
}
