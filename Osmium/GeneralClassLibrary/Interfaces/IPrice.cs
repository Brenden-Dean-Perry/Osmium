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
    }
}
