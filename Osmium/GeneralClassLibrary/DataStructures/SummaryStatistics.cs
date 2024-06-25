using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.DataStructures
{
    public class SummaryStatistics
    {
        public DateOnly MaxDate { get; set; }
        public DateOnly MinDate { get; set; }
        public double TotalDaysInObservationPeriod { get; set; }
        public double TotalWeekdaysInObservationPeriod { get; set; }
        public int ObservationCount { get; set; }
        public decimal LastRecordedValue { get; set; }
        public decimal EarliestRecordedVale { get; set; }
        public decimal Mean { get; set; }
        public decimal Median { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public decimal AnnualizedReturn { get; set; }
        public decimal CumulativeReturn { get; set; }
        public decimal StandardDeviation { get; set; }
        public decimal MaxDrawdownPercentage { get; set; }
        public decimal Correlation { get; set; }
        public decimal Beta { get; set; }
        public decimal SharpeRatio { get; set; }
        public decimal CalmarRatio { get; set; }
        public decimal InformationRatio { get; set; }
        public decimal SortinoRatio { get; set; }
        public decimal TrackingError { get; set; }
        public decimal UpCaptureRatio { get; set; }
        public decimal DownCaptureRatio { get; set; }
        public decimal Alpha { get; set; }
        public decimal Skewness { get; set; }
        public decimal Kurtosis { get; set; }
        public decimal BattingAverage { get; set; }

    }
}
