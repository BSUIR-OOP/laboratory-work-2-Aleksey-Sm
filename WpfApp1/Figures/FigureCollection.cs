using System.Collections.Generic;

namespace OOPLab2.Figures
{
    public class FigureCollection
    {

        public static BaseFigure GetFigure(int cbIndex, Point a, Point b)
        {
            switch (cbIndex)
            {
                case 0: return new Line(a, b);
                case 1: return new Triangle(a, b); 
                case 2: return new Rectangle(a, b);
                case 3: return new Circle(a, b);
                case 4: return new Ellipse(a, b);
                default: return null;
            }
        }
    }
}
