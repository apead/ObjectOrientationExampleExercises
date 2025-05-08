using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises
{
    internal class Rectangle : Shape
    {
        private double length;
        private double breadth;
        public override double GetArea()
        {
            return length * breadth;
        }

        public override string GetShapeName()
        {
            return "Rectangle";
        }

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
    }
}
