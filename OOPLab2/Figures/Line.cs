using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OOPLab2.Figures
{
    public class Line: BaseFigure
    {
        protected Point A { get; set; }
        protected Point B { get; set; }

        public Line(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public override string ToString()
            => $"Line: A({A.x}, {A.y}); B({B.x}, {B.y})";

        public override Shape Draw()
        {
            System.Windows.Shapes.Line line = new System.Windows.Shapes.Line();
            line.X1 = A.x;
            line.Y1 = A.y;
            line.X2 = B.x;
            line.Y2 = B.y;
            line.Stroke = Brushes.Red;
            return line;
        }
    }
}
