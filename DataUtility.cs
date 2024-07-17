namespace data_visualization
{
    using CsvHelper;
    using CsvHelper.Configuration;
    using System.Globalization;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

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

        public static Dictionary<string, List<double>> ExtractFieldDataAsDoubles(List<LiverPatientRecord> recordsList,
                                                                                int? genderFilter = null,
                                                                                int? diseaseFilter = null)
                                                                                
        {
            // Apply filters only if they are not null
            List<LiverPatientRecord> records = recordsList
                .Where(r => (!genderFilter.HasValue || r.Gender == genderFilter.Value) &&
                            (!diseaseFilter.HasValue || r.Dataset == diseaseFilter.Value))
                .ToList();
            Dictionary<string, List<double>> fieldData = new Dictionary<string, List<double>>();

            List<double> ageData = records.Select(r => (double)r.Age).ToList();
            fieldData.Add("Age", ageData);
            List<double> genderData = records.Select(r => (double)r.Gender).ToList();
            fieldData.Add("Gender", genderData);
            List<double> totalBilirubinData = records.Select(r => r.TotalBilirubin).ToList();
            fieldData.Add("TotalBilirubin", totalBilirubinData);
            List<double> directBilirubinData = records.Select(r => r.DirectBilirubin).ToList();
            fieldData.Add("DirectBilirubin", directBilirubinData);
            List<double> alkalinePhosphotaseData = records.Select(r => (double)r.AlkalinePhosphotase).ToList();
            fieldData.Add("AlkalinePhosphotase", alkalinePhosphotaseData);
            List<double> alamineAminotransferaseData = records.Select(r => (double)r.AlamineAminotransferase).ToList();
            fieldData.Add("AlamineAminotransferase", alamineAminotransferaseData);
            List<double> aspartateAminotransferaseData = records.Select(r => (double)r.AspartateAminotransferase).ToList();
            fieldData.Add("AspartateAminotransferase", aspartateAminotransferaseData);
            List<double> totalProteinsData = records.Select(r => r.TotalProteins).ToList();
            fieldData.Add("TotalProtiens", totalProteinsData);
            List<double> albuminData = records.Select(r => r.Albumin).ToList();
            fieldData.Add("Albumin", albuminData); 
            List<double> albuminAndGlobulinRatioData = records.Select(r => r.AlbuminAndGlobulinRatio).ToList();
            fieldData.Add("AlbuminAndGlobulinRatio", albuminAndGlobulinRatioData);
            List<double> datasetData = records.Select(r => (double)r.Dataset).ToList();
            fieldData.Add("Dataset", datasetData);

            return fieldData;
        }


    }



}

