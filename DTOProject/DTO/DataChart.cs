using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOProject.DTO
{
    [Serializable]
    public class DataChart
    {
        public int CountA { get; set; }
        public int CountB { get; set; }
        public int CountC { get; set; }
        public int CountD { get; set; }
        public void refesh()
        {
            CountA = 0;
            CountB = 0;
            CountC = 0;
            CountD = 0;
        }
        public DataChart()
        {
            CountA = 0;
            CountB = 0;
            CountC = 0;
            CountD = 0;
        }
        public DataChart(DataChart dataChart)
        {
            CountA = dataChart.CountA;
            CountB = dataChart.CountB;
            CountC = dataChart.CountC;
            CountD = dataChart.CountD;
        }
    }
}
