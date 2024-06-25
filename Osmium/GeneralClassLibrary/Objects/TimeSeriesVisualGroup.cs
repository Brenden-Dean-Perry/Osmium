using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.Objects
{
    public class TimeSeriesVisualGroup
    {
        private List<TimeSeriesVisual> _TimeSeriesGroup { get; set; } = new List<TimeSeriesVisual>();
        public TimeSeriesVisualGroup()
        {

        }

        public void Clear()
        {
            _TimeSeriesGroup.Clear();
        }

        public void Add(TimeSeriesVisual timeSeries)
        {
            _TimeSeriesGroup.Add(timeSeries);
        }

        public List<TimeSeriesVisual> GetTimeSeriesVisuals()
        {
            return _TimeSeriesGroup;
        }

        public bool DoesTimeSeriesExist(string SeriesName)
        {
            int countOfMatches = _TimeSeriesGroup.Where(x => x.TimeSeries.Name.ToLower() == SeriesName.ToLower()).Count();
            if(countOfMatches >= 1)
            {
                return true;
            }
            return false;
        }
    }
}
