using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Polygon rectangle = new Polygon();
            System.Windows.Point Point1 = new System.Windows.Point(A.x + canvasLeft, A.y);
            System.Windows.Point Point2 = new System.Windows.Point(A.x + canvasLeft + Width, A.y);
            System.Windows.Point Point3 = new System.Windows.Point(A.x + canvasLeft + Width, A.y + Length);
            System.Windows.Point Point4 = new System.Windows.Point(A.x + canvasLeft, A.y + Length);
            PointCollection points = new PointCollection();
            points.Add(Point1);
            points.Add(Point2);
            points.Add(Point3);
            points.Add(Point4);
            rectangle.Points = points;
            rectangle.Stroke = Brushes.Green;
            return rectangle;
        }
    }
}
