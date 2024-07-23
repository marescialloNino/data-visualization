
using Accord.Statistics.Kernels;
using OxyPlot.Series;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;
using liver_disease_prediction.utility;

namespace data_visualization
{
    public static class PlotUtility{


        /// <summary>
        /// Creates a bar plot for binary data, labeling each category with custom labels.
        /// </summary>
        /// <param name="binaryData">List of double values representing binary data (0 or 1).</param>
        /// <param name="title">Title of the plot.</param>
        /// <param name="labels">Dictionary mapping binary values to their string labels.</param>
        /// <returns>A PlotModel object that can be used to display the plot.</returns>
        public static PlotModel CreateBinaryDataPlot(List<double> binaryData, string title, Dictionary<int, string> labels)
        {
            var model = new PlotModel { Title = title, TitleFontSize = 12 };

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


        /// <summary>
        /// Creates a histogram from a list of data.
        /// </summary>
        /// <param name="title">Title of the histogram.</param>
        /// <param name="data">List of data points for the histogram.</param>
        /// <param name="bins">Number of bins to divide the data into (default is 10).</param>
        /// <returns>A PlotModel object representing the histogram.</returns>
        public static PlotModel CreateHistogram(string title, List<double> data, int bins = 10)
        {
            PlotModel plotModel = new PlotModel { Title = title, TitleFontSize = 12 };
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



        /// <summary>
        /// Creates a scatter plot from two lists of data points.
        /// </summary>
        /// <param name="title">Title of the scatter plot.</param>
        /// <param name="xData">List of x-values.</param>
        /// <param name="yData">List of y-values.</param>
        /// <returns>A PlotModel object representing the scatter plot.</returns>
        public static PlotModel CreateScatterPlot(string title, List<double> xData, List<double> yData)
        {
            PlotModel plotModel = new PlotModel { Title = title, TitleFontSize = 12};
            ScatterSeries scatterSeries = new ScatterSeries { MarkerType = MarkerType.Circle , MarkerSize = 2};

            for (int i = 0; i < xData.Count; i++)
            {
                if (i < yData.Count)  // Ensure there is a corresponding y value for each x value
                {
                    scatterSeries.Points.Add(new ScatterPoint(xData[i], yData[i]));
                }
            }

            var xAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                MajorGridlineStyle = LineStyle.Solid,
                MajorGridlineColor = OxyColor.Parse("#E0E0E0") // Light gray grid lines
            };

            var yAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                MajorGridlineStyle = LineStyle.Solid,
                MajorGridlineColor = OxyColor.Parse("#E0E0E0")
            };

            // Adding the axes to the plot model
            plotModel.Axes.Add(xAxis);
            plotModel.Axes.Add(yAxis);

            plotModel.Series.Add(scatterSeries);

            return plotModel;
        }

        /// <summary>
        /// Creates a density plot from a list of data points using a Gaussian kernel.
        /// </summary>
        /// <param name="title">Title of the density plot.</param>
        /// <param name="data">List of data points to be used in the density plot.</param>
        /// <returns>A PlotModel object representing the density plot.</returns>
        public static PlotModel CreateDensityPlot(string title, List<double> data)
        {
            // Setup the Gaussian kernel with the specified bandwidth (found the bandwidth with Silverman 
            // rule of thumb) 
            double stdDev = StatisticsUtility.CalculateStandardDeviation(data);
            double bandwidth = 1.06 * stdDev * Math.Pow(data.Count, -0.2);
            var kernel = new Gaussian(bandwidth);

            PlotModel plotModel = new PlotModel { Title = title, TitleFontSize = 12 };
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


        /// <summary>
        /// Creates and displays a heatmap for a correlation matrix using a PlotView component.
        /// </summary>
        /// <param name="matrix">2D array representing the correlation matrix.</param>
        /// <param name="plotView">The PlotView component where the heatmap will be displayed.</param>
        public static void CreateAndDisplayHeatmap(double[,] matrix, PlotView plotView)
        {
            var model = new PlotModel { Title = "Correlation Matrix Heatmap", TitleFontSize = 12 };
    

            var heatMapSeries = new HeatMapSeries
            {
                X0 = 0,
                X1 = matrix.GetLength(1) ,
                Y0 = matrix.GetLength(0) ,
                Y1 = 0,
                Data = matrix,
                Interpolate = false,  
                RenderMethod = HeatMapRenderMethod.Rectangles 
            };
            
            model.Axes.Add(new LinearColorAxis
                                                {
                                                    Palette = OxyPalettes.Jet(200),
                                                    Position = AxisPosition.Right,
                                                    HighColor = OxyColors.Gray, 
                                                    LowColor = OxyColors.Black
                                                });

            model.Series.Add(heatMapSeries);
            plotView.Model = model;
        }      
    }
}
