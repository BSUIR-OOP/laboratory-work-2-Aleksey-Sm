using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace OOPLab2.Figures
{
    public abstract class BaseFigure
    {
        public abstract override string ToString();


        public abstract Shape Draw();
    }
}
