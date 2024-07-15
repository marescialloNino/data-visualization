using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace data_visualization
{

    // This class is needed to map the csv rows into the LiverPatientRecord class with the right naming
    // convention. Handling missing values in the record.

    public sealed class LiverPatientRecordMap : ClassMap<LiverPatientRecord>
    {
        public LiverPatientRecordMap()
        {
            Map(m => m.Age).Index(0);
            Map(m => m.Gender).Index(1).TypeConverter<GenderToIntConverter>(); ;
            Map(m => m.TotalBilirubin).Index(2); 
            Map(m => m.DirectBilirubin).Index(3);
            Map(m => m.AlkalinePhosphotase).Index(4);
            Map(m => m.AlamineAminotransferase).Index(5);
            Map(m => m.AspartateAminotransferase).Index(6);
            Map(m => m.TotalProtiens).Index(7);
            Map(m => m.Albumin).Index(8);
            Map(m => m.AlbuminAndGlobulinRatio).Index(9).Default(0.95); // handle missing values
            Map(m => m.Dataset).Index(10);
        }
    }

    public class GenderToIntConverter : ITypeConverter
    {
        public object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            // Normalize the text to ensure consistency
            var normalized = text?.Trim().ToLowerInvariant();
            switch (normalized)
            {
                case "male":
                    return 0;
                case "female":
                    return 1;
                default:
                    throw new ArgumentException("Invalid gender value"); // Or return a default value
            }
        }

        public string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
        {
            // Convert the integers back to string if needed, for writing CSVs
            return value switch
            {
                0 => "male",
                1 => "female",
                _ => throw new ArgumentException("Invalid gender value")
            };
        }
    }

}
