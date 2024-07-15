using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace data_visualization
{

    // This class is needed to map the csv rows into the LiverPatientRecord class with the right naming
    // convention. Handling missing values in the record.

    public sealed class LiverPatientRecordMap : ClassMap<LiverPatientRecord>
    {
        public LiverPatientRecordMap()
        {
            Map(m => m.Age).Index(0);
            Map(m => m.Gender).Index(1);
            Map(m => m.TotalBilirubin).Index(2).TypeConverterOption.NullValues(string.Empty, null); 
            Map(m => m.DirectBilirubin).Index(3).TypeConverterOption.NullValues(string.Empty, null);
            Map(m => m.AlkalinePhosphotase).Index(4).TypeConverterOption.NullValues(string.Empty, null);
            Map(m => m.AlamineAminotransferase).Index(5).TypeConverterOption.NullValues(string.Empty, null);
            Map(m => m.AspartateAminotransferase).Index(6).TypeConverterOption.NullValues(string.Empty, null);
            Map(m => m.TotalProtiens).Index(7).TypeConverterOption.NullValues(string.Empty, null);
            Map(m => m.Albumin).Index(8).TypeConverterOption.NullValues(string.Empty, null);
            Map(m => m.AlbuminAndGlobulinRatio).Index(9).TypeConverterOption.NullValues(string.Empty, null);
            Map(m => m.Dataset).Index(10);
        }
    }
}
