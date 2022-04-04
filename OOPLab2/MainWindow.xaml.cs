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
using System.Windows.Shapes;
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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBlock selectedItem = (TextBlock)CBFigureList.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("You didn't choose a shape");
                return;
            }
            BaseFigure figure;
            switch (selectedItem.Text)
            {
                case "Line":
                    figure = new OOPLab2.Figures.Line(
                        new OOPLab2.Figures.Point(int.Parse(AxInput.Text), int.Parse(AyInput.Text)),
                        new OOPLab2.Figures.Point(int.Parse(BxInput.Text), int.Parse(ByInput.Text)));
                    Canv.Children.Add(figure.Draw());
                    break;
                case "Triangle":
                    figure = new OOPLab2.Figures.Triangle(
                        new OOPLab2.Figures.Point(int.Parse(AxInput.Text), int.Parse(AyInput.Text)),
                        new OOPLab2.Figures.Point(int.Parse(BxInput.Text), int.Parse(ByInput.Text)),
                        new OOPLab2.Figures.Point(int.Parse(CxInput.Text), int.Parse(CyInput.Text)));
                    Canv.Children.Add(figure.Draw());
                    break;
                case "Rectangle":
                    figure = new OOPLab2.Figures.Rectangle(
                        new OOPLab2.Figures.Point(int.Parse(AxInput.Text), int.Parse(AyInput.Text)),
                        int.Parse(WidthInput.Text), int.Parse(LengthInput.Text));
                    Canv.Children.Add(figure.Draw());
                    break;
                case "Square":
                    figure = new OOPLab2.Figures.Square(
                        new OOPLab2.Figures.Point(int.Parse(AxInput.Text), int.Parse(AyInput.Text)),
                        int.Parse(LengthInput.Text));
                    Canv.Children.Add(figure.Draw());
                    break;
                case "Ellipse":
                    figure = new OOPLab2.Figures.Ellipse(
                       new OOPLab2.Figures.Point(int.Parse(AxInput.Text), int.Parse(AyInput.Text)),
                       int.Parse(MinorAxisInput.Text), int.Parse(MajorAxisInput.Text));
                    Canv.Children.Add(figure.Draw());
                    break;
                case "Circle":
                    figure = new OOPLab2.Figures.Circle(
                        new OOPLab2.Figures.Point(int.Parse(AxInput.Text), int.Parse(AyInput.Text)),
                        int.Parse(RadiusInput.Text));
                    Canv.Children.Add(figure.Draw());
                    break;
            }
        }
    }
}

