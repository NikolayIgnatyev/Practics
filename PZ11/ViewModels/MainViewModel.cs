using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;

namespace PZ11.ViewModels;

public class MainViewModel : ViewModelBase
{
    [Reactive]
    public (List<double> X, List<double> Y) Points {get; set;}
    public MainViewModel()
    {
        Points = GetPointsFor(2, 8, 0.7, 4.2, 1.5);
    }

    private (List<double> X, List<double> Y) GetPointsFor(double x1, double xn, double step, double a, double b)
    {
        List<double> X = new List<double>();
        List<double> Y = new List<double>();
        for (; x1 <= xn; x1 += step)
        {
            X.Add(x1);
            Y.Add(Func(x1, a, b));
        }

        return (X, Y);
    }

    private double Func(double x, double a, double b)
    {
        return Math.Sqrt(1 + a * x + b * Math.Cos(x));
    }
}
