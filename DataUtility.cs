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
            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                MissingFieldFound = null
            };

            using (StreamReader reader = new StreamReader(filePath))
            using (CsvReader csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<LiverPatientRecordMap>();
                var records = csv.GetRecords<LiverPatientRecord>();
                                                   
                return records.ToList();
            }
        }


    }



}

