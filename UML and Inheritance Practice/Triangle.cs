using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_and_Inheritance_Practice
{
    class Triangle:Shape
    {
        private int Base { get; set; } = 4;
        private int Height { get; set; } = 9;
        private int Result { get; set; }

        public override void GetArea()
        {
            Result= Base * Height / 2;
        }
        public override void toString()
        {
            GetArea();
            Console.WriteLine($"The area of a triangle is {Result}.");
        }

        public Triangle()
        {

        }
    }
}
