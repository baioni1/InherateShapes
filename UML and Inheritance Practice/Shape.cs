using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_and_Inheritance_Practice
{
    abstract class Shape
    {
        private string Color { get; set; }
        public abstract void GetArea();
        public abstract void toString();
        

        
    }
}
