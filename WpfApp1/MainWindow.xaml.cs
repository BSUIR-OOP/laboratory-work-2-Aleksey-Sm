using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using OOPLab2.Figures;

namespace OOPLab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PathGeometry pathGeom = new PathGeometry();

            Circle rect = new Circle(new Figures.Point(100, 100), new Figures.Point(140, 20));

            List<PathFigure> lf = new List<PathFigure>(rect.drawer.Draw(rect.GetDots()));

            foreach (var f in lf)
                pathGeom.Figures.Add(f);

            myPath.Data = pathGeom;
           
            myPath.Stroke = Brushes.Black;
        }
    }
}
