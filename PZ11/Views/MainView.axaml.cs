using Avalonia.Controls;
using PZ11.ViewModels;
using ScottPlot.Avalonia;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PZ11.Views;

public partial class MainView : UserControl
{
    public MainViewModel VM = new MainViewModel();
    public MainView()
    {
        InitializeComponent();

        DataContext = VM;


        PlotAvalonia.Plot.Add.Scatter(VM.Points.X.ToArray(), VM.Points.Y.ToArray());
        PlotAvalonia.Refresh();
    }
}
