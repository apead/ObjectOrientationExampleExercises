using System;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace GraphicsAbstractionExercise.Shapes
{
    public class Circle : Shape
    {
        private int x, y, radius;

        Brush brush;

        private string shapeDescription;

        public Circle(int x, int y, int radius, Brush brush, string shapeDescription)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.brush = brush;
            this.shapeDescription = shapeDescription;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(brush, x - radius, y - radius, radius * 2, radius * 2);
            graphics.DrawEllipse(Pens.White, x - radius, y - radius, radius * 2, radius * 2);

            TextUtils.DrawCenteredText(graphics, string.Format("{0:F2}",GetArea()), new System.Drawing.Rectangle(x - radius, y - radius, radius * 2, radius * 2));
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string GetShapeName()
        {
            return $"Circle {this.shapeDescription}";
        }
    }
}
