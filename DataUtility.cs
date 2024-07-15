namespace data_visualization
{
    using CsvHelper;
    using CsvHelper.Configuration;
    using System.Globalization;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    public static class DataUtility
    {
        public static List<LiverPatientRecord> LoadDataFromCsv()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "indian_liver_patient.csv");
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                MissingFieldFound = null
            };

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<LiverPatientRecordMap>();
                var records = csv.GetRecords<LiverPatientRecord>()
                             .Where(r => r.TotalBilirubin.HasValue &&
                                         r.DirectBilirubin.HasValue &&
                                         r.AlkalinePhosphotase.HasValue &&
                                         r.AlamineAminotransferase.HasValue &&
                                         r.AspartateAminotransferase.HasValue &&
                                         r.TotalProtiens.HasValue &&
                                         r.Albumin.HasValue &&
                                         r.AlbuminAndGlobulinRatio.HasValue);
                              
                return records.ToList();
            }
        }
    }
}

