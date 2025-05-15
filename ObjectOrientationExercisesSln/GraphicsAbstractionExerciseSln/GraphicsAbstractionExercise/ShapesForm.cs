using GraphicsAbstractionExercise.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsAbstractionExercise
{
    public partial class ShapesForm : Form
    {
        private Brush selectedBrush = Brushes.Blue;
        private List<Shape> shapes;

        public ShapesForm()
        {
            InitializeComponent();

            shapes = new List<Shape>();

            redPanel.Click += RedPanel_Click;
            greenPanel.Click += GreenPanel_Click;
            bluePanel.Click += BluePanel_Click;
            cyanPanel.Click += CyanPanel_Click;

            scaleBar.Value = 1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (Shape shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }

        public Point GetRandomPosition()
        {
            Random random = new Random();
            int xPos = random.Next(this.Width);
            int yPos = random.Next(this.Height);

            return new Point(xPos, yPos);
        }


        private void CyanPanel_Click(object sender, EventArgs e)
        {
            selectedBrush = Brushes.Cyan;
        }

        private void BluePanel_Click(object sender, EventArgs e)
        {
            selectedBrush = Brushes.Blue;
        }

        private void GreenPanel_Click(object sender, EventArgs e)
        {
            selectedBrush = Brushes.Green;
        }

        private void RedPanel_Click(object sender, EventArgs e)
        {
            selectedBrush = Brushes.Red;
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            Point pos = GetRandomPosition();
            Shape shape = new Circle(pos.X, pos.Y, 50 * scaleBar.Value, selectedBrush, shapes.Count.ToString());
            shapes.Add(shape);

            AddToListBoxShapeName(shape);

            Invalidate();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            Point pos = GetRandomPosition();

            Shape shape = new Square(pos.X, pos.Y, 50 * scaleBar.Value, selectedBrush, shapes.Count.ToString());

            shapes.Add(shape);

            AddToListBoxShapeName(shape);

            Invalidate();
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            Point pos = GetRandomPosition();

            Shape shape = new Shapes.Rectangle(pos.X, pos.Y, 100 * scaleBar.Value, 50 * scaleBar.Value, selectedBrush, shapes.Count.ToString());

            shapes.Add(shape);

            AddToListBoxShapeName(shape);

            Invalidate();
        }

        private void AddToListBoxShapeName(Shape shape)
        {
            string area = string.Format("{0:F2}", shape.GetArea());
            shapesListbox.Items.Add($"{shape.GetShapeName()} ({area})" );
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            Point pos = GetRandomPosition();

            Shape shape = new Triangle(new Point(pos.X, pos.Y), 100 * scaleBar.Value, 50 * scaleBar.Value, selectedBrush, shapes.Count.ToString());

            shapes.Add(shape);

            AddToListBoxShapeName(shape);

            Invalidate();
        }
    }
    
}
