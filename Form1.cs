using OxyPlot.Series;
using OxyPlot;
using OxyPlot.WindowsForms;
using System.Linq;

namespace data_visualization
{
    public partial class Form1 : Form
    {

        private List<LiverPatientRecord> _records;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "indian_liver_patient.csv");
            try
            {
                _records = DataUtility.LoadDataFromCsv();
                MessageBox.Show("Data loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_records == null || !_records.Any())
            {
                MessageBox.Show("No data loaded. Please load data first.");
                return;
            }

            // Example: Calculate and display the average age
            double averageAge = StatisticsUtility.CalculateMean(_records.Select(r => (double)r.Age).ToList());
            AverageAge.Text = "Average Age: " + averageAge.ToString("F2");


            // Create and display a histogram of Total Bilirubin
            List<double> age = _records.Select(r => (double)r.Age.Value).ToList();
            
            List<double> bilirubinData = _records.Select(r => r.TotalBilirubin ?? 0).ToList(); // Handling potential null values
            PlotModel bilirubinHistogram = PlotUtility.CreateHistogram("age", age);
            plotViewHistogram.Model = bilirubinHistogram;  // plotViewHistogram is the PlotView control for histograms

            // Create and display a scatter plot of Age vs Total Bilirubin
            List<double> ageData = _records.Select(r => (double)r.Age).ToList();
            List<double> bilirubinLevels = _records.Select(r => r.TotalBilirubin ?? 0).ToList();  // Handling potential null values
            PlotModel ageBilirubinScatterPlot = PlotUtility.CreateScatterPlot("Scatter Plot of Age vs Total Bilirubin", ageData, bilirubinLevels);
            plotViewScatter.Model = ageBilirubinScatterPlot;  // plotViewScatter is the PlotView control for scatter plots

            List<double> data = _records.Select(r => r.TotalBilirubin ?? 0).ToList();  // Using Total Bilirubin as an example
            PlotModel BilirubinDensityPlot = PlotUtility.CreateDensityPlot("Density Plot of Total Bilirubin", data);
            plotViewDensity.Model = BilirubinDensityPlot;  // plotView is your OxyPlot PlotView control on the form

            // Calculate the correlation matrix
            double[,] matrix = StatisticsUtility.CalculateCorrelationMatrixForLiverPatientRecords(_records);

            // Display the matrix
            PlotUtility.CreateAndDisplayHeatmap(matrix, plotViewHeatMap);

        }

    }
}
