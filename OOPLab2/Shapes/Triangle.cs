using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.Shapes
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
    }
}
