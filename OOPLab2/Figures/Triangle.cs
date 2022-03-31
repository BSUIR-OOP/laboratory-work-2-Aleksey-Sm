using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OOPLab2.Figures
{
    public class Triangle: Line
    {
        protected Point C { get; set; }

        public Triangle(Point a, Point b, Point c)
            : base(a, b)
        {
            C = c;
        }

        public override string ToString()
            => $"Triangle: A({A.x}, {A.y}), B({B.x}, {B.y}), C({C.x}, {C.y})";

        public override Shape Draw()
        {
            Polygon triang = new Polygon();
            System.Windows.Point Point1 = new System.Windows.Point(A.x, A.y);
            System.Windows.Point Point2 = new System.Windows.Point(B.x, B.y);
            System.Windows.Point Point3 = new System.Windows.Point(C.x, C.y);
            PointCollection points = new PointCollection();
            points.Add(Point1);
            points.Add(Point2);
            points.Add(Point3);
            triang.Points = points;
            triang.Stroke = Brushes.Blue;
            return triang;
        }
    }
}
