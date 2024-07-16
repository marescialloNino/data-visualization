using OxyPlot.Series;
using OxyPlot;
using OxyPlot.WindowsForms;
using System.Linq;
using System.Windows.Forms;
using Accord.Statistics.Models.Fields.Features;

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

            // Display the heatmap
            PlotUtility.CreateAndDisplayHeatmap(matrix, plotViewHeatMap);

            // Display the matrix
            DisplayCorrelationMatrix(matrix);


            PlotModel ageDistributionPlot = PlotUtility.CreateHistogram("Age Distribution", dataDictionary["Age"]);
            plotViewAgeDistribution.Model = ageDistributionPlot;

            string[][] highCorrFeatures = new string[][]
                    {
                                new string[] {"Gender","TotalBilirubin" },
                                new string[] { "AlamineAminotransferase", "AlkalinePhosphotase" },
                                new string[] { "AspartateAminotransferase", "TotalProtiens" },
                                new string[] { "Albumin", "TotalProtiens" },
                                new string[] { "AlbuminAndGlobulinRatio", "Albumin" },
                    };

            

            PlotView[] views = [plotView1, plotView2, plotView3,
                                plotView4, plotView5, plotView6,
                                plotView7, plotView8, plotView9,
                                plotView10, plotView11, plotView12,
                                plotView13, plotView14, plotView15];

            int j = 0;

            foreach ( string[] features in highCorrFeatures)
            {
                int i = 0;

                PlotModel densityPlot1 = PlotUtility.CreateDensityPlot($"Density Plot of {features[i]}", dataDictionary[features[i]]);
                views[j].Model = densityPlot1;
                i++; j++;
                PlotModel densityPlot2 = PlotUtility.CreateDensityPlot($"Density Plot of {features[i]}", dataDictionary[features[i]]);
                views[j].Model = densityPlot2;
                i++; j++;

                PlotModel scatterPlot3 = PlotUtility.CreateScatterPlot($"{features[i - 2]} vs {features[i - 1]} Scatter", dataDictionary[features[i-2]], dataDictionary[features[i-1]]);
                views[j].Model = scatterPlot3;
                i++; j++;
            }




        }

        private void DisplayCorrelationMatrix(double[,] corrMatrix)
        {
            // Example labels for the variables
            string[] labels = new string[]
                                {
                                    "Age",
                                    "Gender",
                                    "Total Bilirubin",
                                    "Direct Bilirubin",
                                    "Alkaline Phosphotase",
                                    "Alamine Aminotransferase",
                                    "Aspartate Aminotransferase",
                                    "Total Protiens",
                                    "Albumin",
                                    "Albumin and Globulin Ratio"
                                };


            int size = corrMatrix.GetLength(0); // Assuming a square matrix

            // Clear existing data
            dataGridCorrelationMatrix.Columns.Clear();
            dataGridCorrelationMatrix.Rows.Clear();
            dataGridCorrelationMatrix.ColumnHeadersVisible = true;
            dataGridCorrelationMatrix.RowHeadersVisible = true;

            // Set up the columns based on the matrix size
            dataGridCorrelationMatrix.ColumnCount = size;
            for (int i = 0; i < size; i++)
            {
                dataGridCorrelationMatrix.Columns[i].Name = labels[i];
                dataGridCorrelationMatrix.Columns[i].HeaderCell.Value = labels[i]; // Setting column headers
            }

            // Adding rows and setting row headers
            for (int i = 0; i < size; i++)
            {
                dataGridCorrelationMatrix.Rows.Add();
                dataGridCorrelationMatrix.Rows[i].HeaderCell.Value = labels[i]; // Setting row headers
            }

            // Populate the DataGridView with values from the matrix
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    dataGridCorrelationMatrix[i, j].Value = corrMatrix[i, j].ToString("F2"); // Format for display
                }
            }

            // Optional: Improve the appearance
            dataGridCorrelationMatrix.AutoResizeColumns();
            dataGridCorrelationMatrix.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridCorrelationMatrix.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void plotViewHeatMap_Click(object sender, EventArgs e)
        {

        }
    }
}
