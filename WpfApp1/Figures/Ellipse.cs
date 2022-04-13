using OOPLab2.Drawing;
using System;
using System.Collections.Generic;

namespace OOPLab2.Figures
{
    public class Ellipse : BaseFigure
    {
        protected Point Center { get; set; }

        protected int MajorAxsis { get; set; }

        protected int MinorAxsis { get; set; }

        public override Drawer drawer { get; set; }

        public Ellipse(Point a, Point b)
        {
            Center = a;
            MajorAxsis = Math.Abs(a.x - b.x);
            MinorAxsis = Math.Abs(a.y - b.y);
            drawer = new EllipseDrawer();
        }

        public override List<Point> GetDots()
            => new List<Point>() { new Point(Center.x - MajorAxsis, Center.y), new Point(Center.x, Center.y - MinorAxsis),
                                   new Point(Center.x + MajorAxsis, Center.y), new Point(Center.x, Center.y + MinorAxsis)};
    }
}
