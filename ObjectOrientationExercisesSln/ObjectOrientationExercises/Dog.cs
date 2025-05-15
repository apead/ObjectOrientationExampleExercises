using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises
{
    internal class Dog : Animal
    {
        public void ProtectsOwner()
        {
            Console.WriteLine("BITE");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Woof");
        }
    }
}
