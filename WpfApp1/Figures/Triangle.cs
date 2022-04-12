using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.Figures
{
    public class Triangle: Line
    {
        protected Point C { get; set; }

        public Triangle(Point a, Point b)
            : base(a, b)
        {
            C = new Point(Math.Abs(a.x - b.x) + Math.Abs(a.x - b.x) / 2, Math.Abs(a.x - b.x) + ((a.x < b.x) ? a.x : b.x));
        }

        public override List<Point> GetDots()
            => new List<Point>() { A, B, C };
    }
}
