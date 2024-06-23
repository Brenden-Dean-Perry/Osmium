using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralClassLibrary.Enums;

namespace GeneralClassLibrary.Utilities
{
    public class TimeSeriesUtilities
    {
        public static SortedDictionary<DateTime, decimal> GetDailyReturns(SortedDictionary<DateTime, decimal> Data)
        {
            SortedDictionary<DateTime, decimal> results = new SortedDictionary<DateTime, decimal>();
            decimal priorValue = 0;
            foreach(KeyValuePair<DateTime, decimal> kvp in Data)
            {
                try
                {
                    decimal returnValue = kvp.Value / priorValue - 1;
                    results.Add(kvp.Key, returnValue);
                }
                catch (DivideByZeroException) { }
                priorValue = kvp.Value;
            }
            return results;
        }

        public static SortedDictionary<DateTime, decimal> GetCumulativeReturns(SortedDictionary<DateTime, decimal> Data)
        {
            SortedDictionary<DateTime, decimal> results = new SortedDictionary<DateTime, decimal>();
            DateTime minDate = Data.Keys.Min();
            decimal startingValue = Data[minDate];
            
            foreach (KeyValuePair<DateTime, decimal> kvp in Data)
            {
               if(kvp.Key != Data.Keys.Min())
               {
                    try
                    {
                        decimal returnValue = kvp.Value / startingValue - 1;
                        results.Add(kvp.Key, returnValue);
                    }
                    catch(DivideByZeroException) { }
               }
            }
            return results;
        }

        public static SortedDictionary<DateTime, decimal> GetWealth(SortedDictionary<DateTime, decimal> Data, decimal StartingWealthValue = 1000)
        {
            SortedDictionary<DateTime, decimal> results = new SortedDictionary<DateTime, decimal>();
            DateTime minDate = Data.Keys.Min();
            decimal startingValue = Data[minDate];

            foreach (KeyValuePair<DateTime, decimal> kvp in Data)
            {
                try
                {
                    decimal returnValue = (kvp.Value / startingValue) * StartingWealthValue;
                    results.Add(kvp.Key, returnValue);
                }
                catch (DivideByZeroException) { }
            }
            return results;
        }

        public static SortedDictionary<DateTime, decimal> GetWealthReverse(SortedDictionary<DateTime, decimal> Data, decimal EndingWealthValue = 1000)
        {
            SortedDictionary<DateTime, decimal> results = new SortedDictionary<DateTime, decimal>();
            DateTime maxDate = Data.Keys.Max();
            decimal endingValue = Data[maxDate];

            foreach (KeyValuePair<DateTime, decimal> kvp in Data)
            {
                try
                {
                    decimal returnValue = (kvp.Value / endingValue) * EndingWealthValue;
                    results.Add(kvp.Key, returnValue);
                }
                catch (DivideByZeroException) { }
            }
            return results;
        }

        public static SortedDictionary<DateTime, decimal> GetDrawdown(SortedDictionary<DateTime, decimal> Data)
        {
            SortedDictionary<DateTime, decimal> results = new SortedDictionary<DateTime, decimal>();
            decimal maxValue = 0;

            foreach (KeyValuePair<DateTime, decimal> kvp in Data)
            {
                if(kvp.Value > maxValue)
                {
                    maxValue = kvp.Value;
                }

                try
                {
                    decimal returnValue = (kvp.Value / maxValue) - 1;
                    results.Add(kvp.Key, returnValue);
                }
                catch(DivideByZeroException) { }
            }
            return results;
        }

        public static SortedDictionary<DateTime, decimal> GetStandardDeviation(SortedDictionary<DateTime, decimal> Data, 
            StatisticsDataSetClassification DataSetClassification = StatisticsDataSetClassification.Sample)
        {
            SortedDictionary<DateTime, decimal> results = new SortedDictionary<DateTime, decimal>();
            foreach (KeyValuePair<DateTime, decimal> kvp in Data)
            {
                decimal windowCount = Data.Where(x => x.Key <= kvp.Key).Count();
                if (DataSetClassification == StatisticsDataSetClassification.Sample)
                {
                    windowCount = windowCount - 1;
                }

                decimal windowAverage = Data.Where(x => x.Key <= kvp.Key).Average(x => x.Value);
                decimal sum = (decimal)Data.Where(x => x.Key <= kvp.Key).Sum(x => Math.Pow((double)(x.Value - windowAverage),2));

                try
                {
                    decimal standardDeviation = (decimal)Math.Sqrt((double)(sum / windowAverage));
                    results.Add(kvp.Key, standardDeviation);
                }
                catch (DivideByZeroException) { }
            }
            return results;
        }


        public static SortedDictionary<DateTime, decimal> GetScaledData(SortedDictionary<DateTime, decimal> Data, decimal Scaler)
        {
            SortedDictionary<DateTime, decimal> results = new SortedDictionary<DateTime, decimal>();
            return new SortedDictionary<DateTime, decimal>(Data.ToDictionary(x => x.Key, x => x.Value * Scaler));
        }
    }
}
