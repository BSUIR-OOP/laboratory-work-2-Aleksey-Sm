using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.Shapes
{
    public class Square: Rectangle
    {
        public Square(Point a, int length)
            : base(a, length, length)
        {

        }

        public override string ToString()
            => $"Square: A({A.x}, {A.y}); B({A.x + Width}, {A.y}); C({A.x + Width}, {A.y + Height}); D({A.x}, {A.y + Height});";
    }
}
