using OOPLab2.Drawing;
using System.Collections.Generic;

namespace OOPLab2.Figures
{
    public class Line : BaseFigure
    {
        protected Point A { get; set; }
        protected Point B { get; set; }

        public override Drawer drawer { get; set; }

        public Line(Point a, Point b)
        {
            A = a;
            B = b;
            drawer = new LineDrawer();
        }

        public override List<Point> GetDots()
            => new List<Point>() { A, B };
    }
}
