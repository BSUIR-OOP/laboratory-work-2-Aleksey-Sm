using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using OOPLab2.Figures;

namespace OOPLab2.Drawing
{
    public abstract class Drawer
    {
        public abstract List<PathFigure> Draw(List<Point> dots);
    }
}
