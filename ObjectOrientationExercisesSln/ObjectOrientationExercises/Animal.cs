using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises
{
    public class Animal
    {
        public virtual void MakeNoise()
        {
            Console.WriteLine("Default Animal Sound");
        }
    }
}
