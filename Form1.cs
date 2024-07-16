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

            Dictionary<string, List<double>> dataDictionary = DataUtility.ExtractFieldDataAsDoubles(_records);


            // DATA ANALYSIS PLOTS

            var genderCount = PlotUtility.CreateBinaryDataPlot(
                                                    dataDictionary["Gender"],
                                                    title: "Gender Distribution",
                                                    labels: new Dictionary<int, string> { { 0, "Male" }, { 1, "Female" } }
                                                );

            plotViewGenderCount.Model = genderCount;

            var hasDiseaseCount = PlotUtility.CreateBinaryDataPlot(
                                        dataDictionary["Dataset"],
                                        title: "Liver Disease Count",
                                        labels: new Dictionary<int, string> { { 1, "Desease" }, { 2, "No Desease" } }
                                    );

            plotViewHasDiseaseCount.Model = hasDiseaseCount;

            // Calculate the correlation matrix
            double[,] matrix = StatisticsUtility.CalculateCorrelationMatrixForLiverPatientRecords(_records);

            // Display the matrix
            PlotUtility.CreateAndDisplayHeatmap(matrix, plotViewHeatMap);


            PlotModel ageDistributionPlot = PlotUtility.CreateHistogram("Age Distribution", dataDictionary["Age"]);
            plotViewAgeDistribution.Model = ageDistributionPlot;  

            List<double> data = _records.Select(r => r.TotalBilirubin).ToList();  // Using Total Bilirubin as an example
            PlotModel BilirubinDensityPlot = PlotUtility.CreateDensityPlot("Density Plot of Total Bilirubin", data);
            plotViewDensity.Model = BilirubinDensityPlot;  
            


        }

    }
}
