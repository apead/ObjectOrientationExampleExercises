using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises.Inheritance
{
    internal class Plane : Vehicle
    {
        public int NumOfWings { get; set; }
        public bool HasTurbine { get; set; }

        public int NumParachutes { get; set; }


        public Plane(string make, string model, int year, int topSpeed, int numWings, bool hasTurbine, int numParachutes) : base(make, model, year, topSpeed)
        {
            NumOfWings = numWings;
            HasTurbine = hasTurbine;
            NumParachutes = numParachutes;
        }

        public override void DisplayDescription()
        {
            base.DisplayDescription();

            Console.WriteLine($"Plane: Number of Wings {NumOfWings} ");
        }
    }
}
