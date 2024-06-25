using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BusinessLogicLibrary.Enums;
using System.Windows.Forms.DataVisualization.Charting;

namespace BusinessLogicLibrary.Objects
{
    public class TimeSeriesVisual
    {
        public TimeSeries TimeSeries { get; set; }
        public Color ChartColor { get; set; }
        public ChartTypeDataTransformations ChartTypeDataTransformations { get; set; } = ChartTypeDataTransformations.Price;
        public bool UsePrimaryAxis { get; set; } = true;
    }
}
