using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_visualization
{
    public static class StatisticsUtility
    {
        public static double CalculateMean(List<double> values)
        {
            return values.Count == 0 ? 0 : values.Average();
        }

        public static double CalculateMedian(List<double> values)
        {
            if (values.Count == 0)
                return 0;

            List<double> sortedValues = values.OrderBy(n => n).ToList();
            int middle = sortedValues.Count / 2;
            if (sortedValues.Count % 2 == 0)
            {
                return (sortedValues[middle] + sortedValues[middle - 1]) / 2.0;
            }
            else
            {
                return sortedValues[middle];
            }
        }

        public static double CalculateStandardDeviation(List<double> values)
        {
            if (values.Count == 0)
                return 0;

            double avg = CalculateMean(values);
            double sum = values.Sum(d => Math.Pow(d - avg, 2));
            return Math.Sqrt((sum) / values.Count);
        }

        public static double[,] CalculateCorrelationMatrixForLiverPatientRecords(List<LiverPatientRecord> records)
        {
            // Extracting numeric fields into separate lists
            List<double> ages = records.Select(x => (double)x.Age).ToList();
            List<double> totalBilirubins = records.Select(x => x.TotalBilirubin).ToList();
            List<double> directBilirubins = records.Select(x => x.DirectBilirubin).ToList();
            List<double> alkalinePhosphotases = records.Select(x => (double)x.AlkalinePhosphotase).ToList();
            List<double> alamineAminotransferases = records.Select(x => (double)x.AlamineAminotransferase).ToList();
            List<double> aspartateAminotransferases = records.Select(x => (double)x.AspartateAminotransferase).ToList();
            List<double> totalProtiens = records.Select(x => x.TotalProtiens).ToList();
            List<double> albumins = records.Select(x => x.Albumin).ToList();
            List<double> albuminAndGlobulinRatios = records.Select(x => x.AlbuminAndGlobulinRatio.Value).ToList();

            // List of all columns
            List<List<double>> columns = new List<List<double>>
        {
            ages, totalBilirubins, directBilirubins, alkalinePhosphotases, alamineAminotransferases,
            aspartateAminotransferases, totalProtiens, albumins, albuminAndGlobulinRatios
        };

            return CalculateCorrelationMatrix(columns);
        }

        public static double[,] CalculateCorrelationMatrix(List<List<double>> columns)
        {
            int n = columns.Count;
            double[,] correlationMatrix = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (i == j)
                    {
                        correlationMatrix[i, j] = 1.0;  // Correlation with itself is always 1
                    }
                    else
                    {
                        double corr = CalculateCorrelation(columns[i], columns[j]);
                        correlationMatrix[i, j] = corr;
                        correlationMatrix[j, i] = corr;  // Correlation matrix is symmetric
                    }
                }
            }

            return correlationMatrix;
        }

        public static double CalculateCorrelation(List<double> x, List<double> y)
        {
            if (x.Count != y.Count || x.Count == 0)
                return 0;

            double meanX = x.Average();
            double meanY = y.Average();
            double sumXY = 0;
            double sumX2 = 0;
            double sumY2 = 0;

            for (int i = 0; i < x.Count; i++)
            {
                double xi = x[i] - meanX;
                double yi = y[i] - meanY;
                sumXY += xi * yi;
                sumX2 += xi * xi;
                sumY2 += yi * yi;
            }

            double stdX = Math.Sqrt(sumX2 / x.Count);
            double stdY = Math.Sqrt(sumY2 / y.Count);
            double covariance = sumXY / x.Count;

            return covariance / (stdX * stdY);
        }
    }

}

