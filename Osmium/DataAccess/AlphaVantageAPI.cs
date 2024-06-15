using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AlphaVantageAPI: GeneralClassLibrary.Interfaces.IPrice
    {
        private InternalAlphaVantageAPI api { get; set; }
        public AlphaVantageAPI(string ApiKey)
        {
            api = new InternalAlphaVantageAPI(ApiKey);
        }

        public decimal GetPrice(string Ticker)
        {
            return api.GetPrice(Ticker);
        }

        public string GetAPITest()
        {
            return api.GetTest();
        }

    }
}
