using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PZ11.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            (List<double> X, List<double> Y) Points = GetPointsWhile(2, 8, 0.7, 4.2, 1.5);

            PlotWpf.Plot.Add.Scatter(Points.X.ToArray(), Points.Y.ToArray());
            PlotWpf.Refresh();
        }

        private (List<double> X, List<double> Y) GetPointsWhile(double x1, double xn, double step, double a, double b)
        {
            List<double> X = new List<double>();
            List<double> Y = new List<double>();
            while(x1 <= xn)
            {
                X.Add(x1);
                Y.Add(Func(x1, a, b));
                x1 += step;
            }

            return (X, Y);
        }

        private double Func(double x, double a, double b)
        {
            return Math.Sqrt(1 + a * x + b * Math.Cos(x));
        }
    }
}