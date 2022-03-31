using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.Figures
{
    public class Circle: Ellipse
    {
        public Circle(Point center, int radius)
            : base(center, radius, radius)
        {

        }

        public override string ToString()
            => $"Circle: Center({Center.x}, {Center.y}), Radius = {MajorAxis}";

        public override System.Windows.Shapes.Shape Draw()
        {
            return base.Draw();
        }
    }
}
