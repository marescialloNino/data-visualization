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
            Dictionary<string, List<double>> maleDeseaseDictionary = DataUtility.ExtractFieldDataAsDoubles(_records, 0, 1);
            Dictionary<string, List<double>> maleNoDiseaseDictionary = DataUtility.ExtractFieldDataAsDoubles(_records, 0, 2);
            Dictionary<string, List<double>> femaleDiseaseDictionary = DataUtility.ExtractFieldDataAsDoubles(_records, 1, 1);
            Dictionary<string, List<double>> femaleNoDiseaseDictionary = DataUtility.ExtractFieldDataAsDoubles(_records, 1, 2);


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
            double[,] matrix = StatisticsUtility.CalculateCorrelationMatrixForLiverPatientRecords(dataDictionary);

            // Display the heatmap
            PlotUtility.CreateAndDisplayHeatmap(matrix, plotViewHeatMap);

            // Display the matrix
            DisplayCorrelationMatrix(matrix);


            PlotModel ageDistributionPlot = PlotUtility.CreateHistogram("Age Distribution", dataDictionary["Age"]);
            plotViewAgeDistribution.Model = ageDistributionPlot;

            string[][] highCorrFeatures = new string[][]
                    {
                                new string[] { "TotalBilirubin","DirectBilirubin" },
                                new string[] { "AlamineAminotransferase", "AlkalinePhosphotase" },
                                new string[] { "AspartateAminotransferase", "TotalProtiens" },
                                new string[] { "Albumin", "TotalProtiens" },
                                new string[] { "AlbuminAndGlobulinRatio","Albumin" },
                    };



            PlotView[] viewsScatter = [plotView1, plotView2, plotView3, plotView4, plotView5];

            int j = 0;

            foreach (string[] features in highCorrFeatures)
            {

                PlotModel scatterPlot = PlotUtility.CreateScatterPlot($"{features[0]} vs {features[1]} Scatter", dataDictionary[features[0]], dataDictionary[features[1]]);
                viewsScatter[j].Model = scatterPlot;
                j++;
            }

            PlotModel histogram1 = PlotUtility.CreateHistogram("Male disease by age", maleDeseaseDictionary["Age"]);
            plotView6.Model = histogram1;
            PlotModel histogram2 = PlotUtility.CreateHistogram("Male no disease by age", maleNoDiseaseDictionary["Age"]);
            plotView7.Model = histogram2;
            PlotModel histogram3 = PlotUtility.CreateHistogram("Female disease by age", femaleDiseaseDictionary["Age"]);
            plotView8.Model = histogram3;
            PlotModel histogram4 = PlotUtility.CreateHistogram("Female no disease by age", femaleNoDiseaseDictionary["Age"]);
            plotView9.Model = histogram4;


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

        private void plotView3_Click(object sender, EventArgs e)
        {

        }

        private void plotView9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridCorrelationMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
