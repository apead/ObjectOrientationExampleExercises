using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises.Abstraction
{
    internal class Square : Shape
    {
        private double side;

        private double area;
        public override double GetArea()
        {
            return side * side;
        }

        public override string GetShapeName()
        {
            return "Square";
        }

        public Square(double side)
        {
            this.side = side;

         //   area = side * side;
        }
    }
}
