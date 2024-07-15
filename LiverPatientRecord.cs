using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace data_visualization
{
    public class LiverPatientRecord
    {
        public int Age { get; set; }
        public int Gender { get; set; }
        public double TotalBilirubin { get; set; }
        public double DirectBilirubin { get; set; }
        public int AlkalinePhosphotase { get; set; }
        public int AlamineAminotransferase { get; set; }
        public int AspartateAminotransferase { get; set; }
        public double TotalProtiens { get; set; }
        public double Albumin { get; set; }
        public double? AlbuminAndGlobulinRatio { get; set; } // some values in the dataset might not be present
        public int Dataset { get; set; } // 1: has disease, 2: no disease
    }
}
