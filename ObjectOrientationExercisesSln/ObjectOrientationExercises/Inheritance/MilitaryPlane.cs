using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises.Inheritance
{
    internal class MilitaryPlane : Plane
    {
        public int NumGuns { get; set; }

        public MilitaryPlane(string make, string model, int year, int topSpeed, int numWings, bool hasTurbine, int numParachutes, int numGuns) : base(make, model, year, topSpeed, numWings, hasTurbine, numParachutes)
        {
            NumGuns = numGuns;
        }
    }
}
