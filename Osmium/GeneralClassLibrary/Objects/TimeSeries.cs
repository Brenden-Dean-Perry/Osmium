using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary.Enums;

namespace BusinessLogicLibrary.Objects
{
    public class TimeSeries
    {
        public string Name { get; set; } = String.Empty;
        public TimeSeriesPurpose TimeSeriesPurpose { get; set; } = TimeSeriesPurpose.Unclassified;
        public SortedDictionary<DateTime, decimal> TimeSeriesData { get; set; } = new SortedDictionary<DateTime, decimal>();

        public TimeSeries()
        {

        }
    }
}
