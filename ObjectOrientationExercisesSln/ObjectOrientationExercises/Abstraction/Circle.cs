using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises.Abstraction
{
    internal class Circle : Shape
    {
        private double radius;

        public override double GetArea()
        {

            return Math.PI * radius * radius; //Math.Pow( radius, 2);
        }

        public override string GetShapeName()
        {
            return "Circle";
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
    }
}
