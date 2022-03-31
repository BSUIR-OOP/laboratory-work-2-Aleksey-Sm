using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.Shapes
{
    public class Rectangle: BaseFigure
    {
        protected Point A { get; set; }

        protected int Width { get; set; }

        protected int Height { get; set; }

        public Rectangle(Point a, int width, int height)
        {
            A = a;
            Width = width;
            Height = height;
        }

        public override string ToString()
            => $"Rectangle: A({A.x}, {A.y}); B({A.x + Width}, {A.y}); C({A.x + Width}, {A.y + Height}); D({A.x}, {A.y + Width});";
    }
}
