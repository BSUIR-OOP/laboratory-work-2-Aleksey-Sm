using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OOPLab2.Figures
{
    public class Rectangle: BaseFigure
    {
        protected Point A { get; set; }

        protected int Width { get; set; }

        protected int Length { get; set; }

        public Rectangle(Point a, int width, int length)
        {
            A = a;
            Width = width;
            Length = length;
        }

        public override string ToString()
            => $"Rectangle: A({A.x}, {A.y}); B({A.x + Width}, {A.y}); C({A.x + Width}, {A.y + Length}); D({A.x}, {A.y + Length});";

        public override Shape Draw()
        {
            System.Windows.Shapes.Rectangle rectangle = new System.Windows.Shapes.Rectangle();
            rectangle.Width = Width;
            rectangle.Height = Length;
            rectangle.Stroke = Brushes.Blue;
            Canvas.SetLeft(rectangle, A.x + canvasLeft);
            Canvas.SetTop(rectangle, A.y);
            return rectangle;
        }
    }
}
