using System.Drawing;

namespace GraphicsAbstractionExercise.Shapes
{
    public abstract class Shape
    {
        public abstract void Draw(Graphics graphics);

        public abstract double GetArea();

        public abstract string GetShapeName();

    }
}
