﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BusinessLogicLibrary.Enums;

namespace BusinessLogicLibrary.Objects
{
    public class TimeSeriesVisual
    {
        public TimeSeries TimeSeries { get; set; } = new TimeSeries();
        public Color ChartColor { get; set; }
        public ChartType ChartType { get; set; }
        public ChartTypeDataTransformations ChartTypeDataTransformations { get; set; } = ChartTypeDataTransformations.Price;
        public bool UsePrimaryAxis { get; set; } = true;

        public TimeSeriesVisual()
        {

        }
    }
}
