using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLab2.Drawing;

namespace OOPLab2.Figures
{
    public class Rectangle: BaseFigure
    {
        protected Point A { get; set; }

        protected Point B { get; set; }

        public Drawer drawer;

        public Rectangle(Point a, Point b)
        {
            A = a;
            B = b;
            drawer = new LineDrawer();
        }

        public override List<Point> GetDots()
            => new List<Point>() { A, new Point(B.x, A.y), B, new Point(A.x, B.y)};


    }
}
