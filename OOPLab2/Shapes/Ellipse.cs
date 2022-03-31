using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.Shapes
{
    public class Ellipse: BaseFigure
    {
        protected Point Center { get; set; }

        protected int MinorAxis { get; set; }

        protected int MajorAxis { get; set; }

        public Ellipse(Point center, int minorAxis, int majorAxis)
        {
            Center = center;
            MinorAxis = minorAxis;
            MajorAxis = majorAxis;
        }

        public override string ToString()
            => $"Ellipse: Center({Center.x}, {Center.y}), MajorAxis = {MajorAxis}, MinorAxis = {MinorAxis}";
    }
}
