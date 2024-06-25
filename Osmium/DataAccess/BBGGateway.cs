using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using DataAccess.DataModels;

namespace DataAccess
{
    public class BBGGateway
    {
        private IBBGAPI _BBGAPI { get; set; }

        public BBGGateway(IBBGAPI API)
        {
            _BBGAPI = API;
        }

        public void OpenConnection()
        {
            _BBGAPI.StartSession();
        }

        public bool IsDataFeedConnected()
        {
            return _BBGAPI.IsBloombergConnected();
        }

        public void CloseConnection()
        {
            _BBGAPI.KillConnection();
        }

        public string GetDataPoint(string Ticker, string Field)
        {
            BBGAPIDataPoint results = _BBGAPI.BDP(Ticker, Field);
            return results.GetValue(Ticker, Field);
        }

        public decimal GetHistoricalPoint(string Ticker, string Field, DateTime Date, bool FillPrices = false)
        {
            BBGAPIHistoricalDataPoint results = _BBGAPI.BDH(Ticker, Field, Date, Date, FillPrices);
            return results.GetValue(Ticker, Field, Date);
        }
    }
}
