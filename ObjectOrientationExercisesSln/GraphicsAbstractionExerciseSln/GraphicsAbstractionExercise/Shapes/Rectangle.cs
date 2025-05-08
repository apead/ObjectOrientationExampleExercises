using System.Drawing;

namespace GraphicsAbstractionExercise.Shapes
{
    public class Rectangle : Shape
    {
        private int x, y, width, height;
        Brush brush;
        private string shapeDescription;

        public Rectangle(int x, int y, int width, int height, Brush brush, string shapeDescription)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.brush = brush;
            this.shapeDescription = shapeDescription;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(brush, x, y, width, height);
            graphics.DrawRectangle(Pens.White, x, y, width, height);

            TextUtils.DrawCenteredText(graphics, string.Format("{0:F2}", GetArea()), new System.Drawing.Rectangle(x, y, width, height));
        }

        public override double GetArea()
        {
            return width * height;
        }

        public override string GetShapeName()
        {
            return $"Rectangle {this.shapeDescription}";
        }
    }
}