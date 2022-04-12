using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.Figures
{
    public class Circle: Ellipse
    {
        public Circle(Point a, Point b)
            : base(a, b)
        {
            MajorAxsis = MinorAxsis = Math.Abs(b.x - a.x);
        }

        public override List<Point> GetDots()
        {
            return base.GetDots();
        }

    }
}
