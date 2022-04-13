using OOPLab2.Figures;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace OOPLab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BaseFigure figure;
        private PathGeometry pathGeom;
        private PathFigureCollection figureCollection;
        private Figures.Point initialMousePosition;
        private Figures.Point endMousePosition;

        public MainWindow()
        {
            InitializeComponent();
            pathGeom = new PathGeometry();
            figureCollection = new PathFigureCollection();
            myPath.Stroke = Brushes.Black;
        }

        private void myPath_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var currentPosition = e.GetPosition(myPath);
            initialMousePosition = new Figures.Point((int)currentPosition.X, (int)currentPosition.Y);
        }

        private void myPath_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var endPosition = e.GetPosition(myPath);
            endMousePosition = new Figures.Point((int)endPosition.X, (int)endPosition.Y);
            FigureCollection figuresCollection = new FigureCollection(initialMousePosition, endMousePosition);
            figure = figuresCollection.GetFigure(cbFigures.SelectedIndex);
            List<PathFigure> pathFigureList = new List<PathFigure>(figure.drawer.Draw(figure.GetDots()));
            foreach (var f in pathFigureList)
                figureCollection.Add(f);
            pathGeom.Figures = figureCollection;
            myPath.Data = pathGeom;
        }
    }
}
