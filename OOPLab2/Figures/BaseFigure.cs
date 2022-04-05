using System.Windows.Shapes;

namespace OOPLab2.Figures
{
    public abstract class BaseFigure
    {
        protected const int canvasLeft = 225;

        public abstract override string ToString();

        public abstract Shape Draw();
    }
}
