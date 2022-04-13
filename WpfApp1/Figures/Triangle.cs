using System;
using System.Collections.Generic;

namespace OOPLab2.Figures
{
    public class Triangle : Line
    {
        protected Point C { get; set; }

        public Triangle(Point a, Point b)
            : base(a, b)
        {
            C = new Point(Math.Abs(a.x - b.x) / 2 + a.x, 3 * Math.Abs(a.x - b.x) / 4);
        }

        public override List<Point> GetDots()
            => new List<Point>() { A, B, C };
    }
}
