using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.Shapes
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
    }
}
