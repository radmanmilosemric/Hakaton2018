using System.Collections.Generic;

namespace Models
{
    public class Chart
    {
        public string[] labels { get; set; }
        public List<Datasets> datasets { get; set; }
    }
    public class Datasets
    {
        public string label { get; set; }
        public string type { get; set; }
        public string[] data { get; internal set; }
        public bool fill { get; internal set; }
        public string borderColor { get; internal set; }
        public string backgroundColor { get; internal set; }
        public string pointBorderColor { get; internal set; }
        public string pointBackgroundColor { get; internal set; }
        public string pointHoverBackgroundColor { get; internal set; }
        public string pointHoverBorderColor { get; internal set; }
        public string yAxisID { get; internal set; }
        public string xAxisID { get; internal set; }
    }
}