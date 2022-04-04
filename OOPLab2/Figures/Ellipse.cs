using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OOPLab2.Figures
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

        public override Shape Draw()
        {
            System.Windows.Shapes.Ellipse ellipse = new System.Windows.Shapes.Ellipse();
            ellipse.Width = MajorAxis * 2;
            ellipse.Height = MinorAxis * 2;
            Canvas.SetLeft(ellipse, Center.x - MajorAxis + canvasLeft);
            Canvas.SetTop(ellipse, Center.y - MinorAxis);
            ellipse.Stroke = Brushes.Black;
            return ellipse;
        }
    }
}
