using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Kernels;
using Accord.Statistics.Distributions.Univariate;
using OxyPlot.Series;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;
using System.Reflection;
using OxyPlot.Annotations;

namespace data_visualization
{
    public static class PlotUtility{


        public static PlotModel CreateBinaryDataPlot(List<double> binaryData, string title, Dictionary<int, string> labels)
        {
            var model = new PlotModel { Title = title };

            // Define axes
            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0 };

            // Set category labels from the labels dictionary
            foreach (var label in labels)
            {
                categoryAxis.Labels.Add(label.Value);
            }

            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);

            // Create a BarSeries
            var series = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}"
            };

            // Fill series with data based on the binaryData list
            foreach (var label in labels)
            {
                int count = binaryData.Count(value => value == label.Key);
                series.Items.Add(new BarItem { Value = count });
            }

            model.Series.Add(series);

            return model;
        }

        public static PlotModel CreateHistogram(string title, List<double> data, int bins = 10)
        {
            PlotModel plotModel = new PlotModel { Title = title };
            HistogramSeries histogramSeries = new HistogramSeries
            {
                StrokeThickness = 1,
                StrokeColor = OxyColors.Black,
            };

            double min = data.Min();
            double max = data.Max();
            int binCount = bins; // Fixed number of bins
            double binWidth = (max - min) / binCount; // Calculate bin width based on the range and fixed bin count

            for (int i = 0; i < binCount; i++)
            {
                double lower = min + i * binWidth;
                double upper = lower + binWidth;
                int count = data.Count(val => val >= lower && val < upper);
                double area = count * binWidth; // Optionally define area as count times bin width, or use other definition

                HistogramItem item = new HistogramItem(lower, upper, area, count);
                histogramSeries.Items.Add(item);
            }

            plotModel.Series.Add(histogramSeries);
            return plotModel;
        }


        public static PlotModel CreateScatterPlot(string title, List<double> xData, List<double> yData)
    {
        PlotModel plotModel = new PlotModel { Title = title };
        ScatterSeries scatterSeries = new ScatterSeries { MarkerType = MarkerType.Circle };

        for (int i = 0; i < xData.Count; i++)
        {
            if (i < yData.Count)  // Ensure there is a corresponding y value for each x value
            {
                scatterSeries.Points.Add(new ScatterPoint(xData[i], yData[i]));
            }
        }

        plotModel.Series.Add(scatterSeries);
        return plotModel;
    }

        public static PlotModel CreateDensityPlot(string title, List<double> data, double bandwidth = 1)
        {
            // Setup the Gaussian kernel with the specified bandwidth (found the bandwidth in heuristic way based
            // on the fields)
            var kernel = new Gaussian(bandwidth);

            PlotModel plotModel = new PlotModel { Title = title };
            LineSeries series = new LineSeries();

            double min = data.Min();
            double max = data.Max();
            double range = max - min;
            double step = range / 1000;  // Defines the resolution of the density plot

            // Create a range of values over which to calculate the density
            var grid = Enumerable.Range(0, 1000)
                                 .Select(x => min + x * step)
                                 .ToArray();

            // Prepare the data array and weights for the kernel density estimation
            double[] dataArray = data.ToArray();
            double[] weights = Enumerable.Repeat(1.0 / dataArray.Length, dataArray.Length).ToArray();

            // Compute the density at each point in the grid
            foreach (var x in grid)
            {
                double density = 0;
                for (int i = 0; i < dataArray.Length; i++)
                {
                    density += weights[i] * kernel.Function((x - dataArray[i]) / bandwidth);
                }
                series.Points.Add(new DataPoint(x, density / bandwidth));
            }

            plotModel.Series.Add(series);
            return plotModel;
        }

        

        public static void CreateAndDisplayHeatmap(double[,] matrix, PlotView plotView)
        {
            var model = new PlotModel { Title = "Correlation Matrix Heatmap" };
            // Create a new data array with inverted Y-axis to obtain the "right" correlation matrix
            double[,] invertedMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // Invert the index for the Y-axis
                    invertedMatrix[matrix.GetLength(0) - 1 - i, j] = matrix[i, j];
                }
            }

            var heatMapSeries = new HeatMapSeries
            {
                X0 = 0,
                X1 = invertedMatrix.GetLength(1) - 1,
                Y0 = 0,
                Y1 = invertedMatrix.GetLength(0) - 1,
                Data = invertedMatrix,
               // Interpolate = true,
               // RenderMethod = HeatMapRenderMethod.Bitmap
                Interpolate = false,  // Disable smoothing
                RenderMethod = HeatMapRenderMethod.Rectangles // Use rectangles for rendering each cell
            };

            // Cake type axis (vertical)
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = "fields axis",
                ItemsSource = new[]
                    {
                        "age",
                        "bilirubin",
                        "Bundt cake", 
                        "Chocolate cake",
                        "Carrot cake","","","","",""
                    }
            });
            // Define color axis
            // Define the color axis for the model, not directly on the heatMapSeries
            model.Axes.Add(new LinearColorAxis
            {
                Palette = OxyPalettes.Jet(200),
                Position = AxisPosition.Right,
                HighColor = OxyColors.Gray, // Optionally define the colors for out-of-bounds values
                LowColor = OxyColors.Black
            });

            model.Series.Add(heatMapSeries);
            plotView.Model = model;
        } 
    }
}
