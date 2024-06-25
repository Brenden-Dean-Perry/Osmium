using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.Interfaces
{
    public interface IExchangeRate
    {
        public decimal GetExchangeRate(string FromCurrencySymbol, string ToCurrencySymbol);
        public DateTime GetLastRefreshDateTime(string FromCurrencySymbol, string ToCurrencySymbol);

    }
}
