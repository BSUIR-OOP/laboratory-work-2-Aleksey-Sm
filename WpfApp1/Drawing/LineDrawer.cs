using OOPLab2.Figures;
using System.Collections.Generic;
using System.Windows.Media;

namespace OOPLab2.Drawing
{
    public class LineDrawer : Drawer
    {
        public override PathFigureCollection Draw(List<Point> dots)
        {
            PathFigureCollection result = new PathFigureCollection();
            PathFigure f;
            LineSegment line;
            for (int i = 0; i < dots.Count - 1; i++)
            {
                f = new PathFigure();
                line = new LineSegment();
                f.StartPoint = new System.Windows.Point(dots[i].x, dots[i].y);
                line.Point = new System.Windows.Point(dots[i + 1].x, dots[i + 1].y);
                f.Segments.Add(line);
                result.Add(f);
            }
            f = new PathFigure();
            line = new LineSegment();
            f.StartPoint = new System.Windows.Point(dots[0].x, dots[0].y);
            line.Point = new System.Windows.Point(dots[dots.Count - 1].x, dots[dots.Count - 1].y);
            f.Segments.Add(line);
            result.Add(f);
            return result;
        }
    }
}
