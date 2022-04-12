using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLab2.Drawing;

namespace OOPLab2.Figures
{
    public class Ellipse: BaseFigure
    {
        protected Point Center { get; set; }

        protected int MajorAxsis { get; set; }

        protected int MinorAxsis { get; set; }

        public Drawer drawer;

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
