using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLab2.Drawing;

namespace OOPLab2.Figures
{
    public class Line: BaseFigure
    {
        protected Point A { get; set; }
        protected Point B { get; set; }

        public Drawer drawer;

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
