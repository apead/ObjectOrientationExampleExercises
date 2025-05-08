using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises.Inheritance
{
    internal class Boat : Vehicle
    {
        public bool IsFloating { get; set; }

        public int WaveBreakerSpeed { get; set; }

        public int NumLifeBoats { get; set; }

        public Boat(string make, string model, int year, int topSpeed, bool isFloating, int waveBreakerSpeed, int numLifeBoats) : base(make, model, year, topSpeed)
        {
            IsFloating = isFloating;
            WaveBreakerSpeed = waveBreakerSpeed;
            NumLifeBoats = numLifeBoats;
        }

        public override void DisplayDescription()
        {
          //  base.DisplayDescription();

            Console.WriteLine($"Boat:  IsFloating: {IsFloating}");

        }
    }
}
