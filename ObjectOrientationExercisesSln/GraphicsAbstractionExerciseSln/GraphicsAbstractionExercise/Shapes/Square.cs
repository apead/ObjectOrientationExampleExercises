using System.Drawing;

namespace GraphicsAbstractionExercise.Shapes
{
    public class Square : Shape
    {
        private int x, y, side;
        Brush brush;
        private string shapeDescription;

        public Square(int x, int y, int side, Brush brush, string shapeDescription)
        {
            this.x = x;
            this.y = y;
            this.side = side;
            this.brush = brush;
            this.shapeDescription = shapeDescription;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(brush, x, y, side, side);
            graphics.DrawRectangle(Pens.White, x, y, side, side);
            TextUtils.DrawCenteredText(graphics, string.Format("{0:F2}", GetArea()), new System.Drawing.Rectangle(x, y, side, side));

        }

        public override double GetArea()
        {
            return side * side;
        }

        public override string GetShapeName()
        {
            return $"Square {this.shapeDescription}";
        }
    }
}