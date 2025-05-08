using System.Drawing;

namespace GraphicsAbstractionExercise.Shapes
{
    internal class Triangle : Shape
    {
        private Point[] points;
        private int width;
        private int height;

        private Brush brush;
        private string shapeDescription;

        public Triangle(Point topLeft, int width, int height, Brush brush, string shapeDescription)
        {
            points = new Point[]
            {
            topLeft,                                
            new Point(topLeft.X, topLeft.Y + height), 
            new Point(topLeft.X + width, topLeft.Y)   
            };

            this.width = width;
            this.height = height;

            this.brush = brush;
            this.shapeDescription = shapeDescription;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillPolygon(brush, points);
            graphics.DrawPolygon(Pens.White, points);

            TextUtils.DrawCenteredText(graphics, string.Format("{0:F2}", GetArea()), new System.Drawing.Rectangle(points[0].X, points[0].Y, width / 2, height));

        }

        public override double GetArea()
        {
            return 0.5 * width * height;
        }

        public override string GetShapeName()
        {
            return $"Rectangle {this.shapeDescription}";
        }
    }
}
