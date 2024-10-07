using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;
using System;
using System.Windows;

namespace ComplexityGraphs
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadTimeComplexityGraph();
            LoadSpaceComplexityGraph();
        }

        private void LoadTimeComplexityGraph()
        {
            // Initialize the plot model and set the title
            var algorithmComplexityModel = new PlotModel { Title = "Algorithm and Data Structure Time Complexities" };

            // Configure the legend for the graph
            algorithmComplexityModel.IsLegendVisible = true;
            var legend = new Legend
            {
                LegendTitle = "Growth Rates",
                LegendPosition = LegendPosition.TopRight,
                LegendOrientation = LegendOrientation.Vertical,
                LegendPlacement = LegendPlacement.Outside
            };
            algorithmComplexityModel.Legends.Add(legend);

            // Add time complexity functions for algorithms and data structures
            AddAlgorithmComplexitySeries(algorithmComplexityModel, "Accessing Array Element O(1)", OxyColor.FromRgb(0, 0, 255), i => 1); // O(1) - Array Access
            AddAlgorithmComplexitySeries(algorithmComplexityModel, "Binary Search O(log n)", OxyColor.FromRgb(255, 165, 0), i => Math.Log(i, 2)); // O(log n) - Binary Search
            AddAlgorithmComplexitySeries(algorithmComplexityModel, "Linear Search O(n)", OxyColor.FromRgb(0, 255, 0), i => i); // O(n) - Linear Search
            AddAlgorithmComplexitySeries(algorithmComplexityModel, "Merge Sort O(n log n)", OxyColor.FromRgb(255, 0, 0), i => i * Math.Log(i, 2)); // O(n log n) - Merge Sort
            AddAlgorithmComplexitySeries(algorithmComplexityModel, "Bubble Sort O(n²)", OxyColor.FromRgb(128, 0, 128), i => i * i); // O(n²) - Bubble Sort

            // Cap the upper limit for factorial and exponential functions to prevent graph compression
            AddAlgorithmComplexitySeries(algorithmComplexityModel, "Fibonacci Recursive O(2^n)", OxyColor.FromRgb(165, 42, 42), i => Math.Pow(2, i), maxLimit: 10); // O(2^n) - Fibonacci Recursive (limited to 15)
            AddAlgorithmComplexitySeries(algorithmComplexityModel, "Travelling Salesman O(n!)", OxyColor.FromRgb(255, 192, 203), i => Factorial(i), maxLimit: 6); // O(n!) - Travelling Salesman (limited to 10)

            // Assign the model to the plot view
            TimePlotView.Model = algorithmComplexityModel;
        }

        private void AddAlgorithmComplexitySeries(PlotModel model, string title, OxyColor color, Func<int, double> complexityFunction, int maxLimit = 20)
        {
            var series = new LineSeries
            {
                Title = title,
                Color = color
            };

            // Generate data points for the series, respecting the max limit
            for (int i = 1; i <= maxLimit; i++)
            {
                series.Points.Add(new DataPoint(i, complexityFunction(i)));
            }

            model.Series.Add(series);
        }

        private void LoadSpaceComplexityGraph()
        {
            var model = new PlotModel { Title = "Space Complexity" };

            // Configure Legend settings
            model.IsLegendVisible = true;

            // Create and configure the legend
            var legend = new Legend
            {
                LegendTitle = "Space Complexities",
                LegendPosition = LegendPosition.TopRight,
                LegendOrientation = LegendOrientation.Vertical,
                LegendPlacement = LegendPlacement.Outside
            };

            model.Legends.Add(legend);

            // O(1)
            var line1 = new LineSeries { Title = "O(1)", Color = OxyColor.FromRgb(0, 0, 255) };
            for (int i = 0; i <= 20; i++)
                line1.Points.Add(new DataPoint(i, 1));

            // O(n)
            var line2 = new LineSeries { Title = "O(n)", Color = OxyColor.FromRgb(0, 255, 0) };
            for (int i = 0; i <= 20; i++)
                line2.Points.Add(new DataPoint(i, i));

            // O(n²)
            var line3 = new LineSeries { Title = "O(n²)", Color = OxyColor.FromRgb(128, 0, 128) };
            for (int i = 0; i <= 20; i++)
                line3.Points.Add(new DataPoint(i, i * i));

            model.Series.Add(line1);
            model.Series.Add(line2);
            model.Series.Add(line3);

            SpacePlotView.Model = model;
        }

        private double Factorial(int n)
        {
            if (n == 0) return 1;
            double result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            return result;
        }
    }
}
