using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassLibrary.Interfaces
{
    public interface IPrice
    {
        public decimal GetPrice(string Ticker);
        public decimal GetVolume(string Ticker);
        public decimal GetPricePreviousClose(string Ticker);
        public decimal GetPriceLow(string Ticker);
        public decimal GetPriceHigh(string Ticker);
        public DateTime GetLatestTradingDay(string Ticker);
        public decimal GetChangePercentage(string Ticker);
    }
}
