using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.Figures
{
    public class Square: Rectangle
    {
        public Square(Point a, int length)
            : base(a, length, length)
        {

        }

        public override string ToString()
            => $"Square: A({A.x}, {A.y}); B({A.x + Width}, {A.y}); C({A.x + Width}, {A.y + Length}); D({A.x}, {A.y + Length});";

        public override System.Windows.Shapes.Shape Draw()
            => base.Draw();
    }
}
