using OOPLab2.Figures;
using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace OOPLab2.Drawing
{
    public class EllipseDrawer : Drawer
    {
        public override PathFigureCollection Draw(List<Point> dots)
        {
            PathFigureCollection result = new PathFigureCollection();
            PathFigure f = new PathFigure();
            ArcSegment arc1 = new ArcSegment();
            for (int i = 0; i < dots.Count - 1; i++)
            {
                f = new PathFigure();
                arc1 = new ArcSegment();
                f.StartPoint = new System.Windows.Point(dots[i].x, dots[i].y);
                arc1.Point = new System.Windows.Point(dots[i + 1].x, dots[i + 1].y);
                arc1.Size = new System.Windows.Size(Math.Abs(dots[0].x - dots[2].x) / 2, Math.Abs(dots[1].y - dots[3].y) / 2);
                arc1.SweepDirection = (i > dots.Count / 2) ? SweepDirection.Counterclockwise : SweepDirection.Clockwise;
                f.Segments.Add(arc1);
                result.Add(f);
            }
            f = new PathFigure();
            arc1 = new ArcSegment();
            f.StartPoint = new System.Windows.Point(dots[0].x, dots[0].y);
            arc1.Point = new System.Windows.Point(dots[3].x, dots[3].y);
            arc1.Size = new System.Windows.Size(Math.Abs(dots[0].x - dots[2].x) / 2, Math.Abs(dots[1].y - dots[3].y) / 2);
            arc1.SweepDirection = SweepDirection.Counterclockwise;
            f.Segments.Add(arc1);
            result.Add(f);
            return result;
        }
    }
}
