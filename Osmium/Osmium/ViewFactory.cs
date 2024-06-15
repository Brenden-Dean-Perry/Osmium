using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osmium
{
    internal class ViewFactory
    {
        internal Form CreateMarketAccess()
        {
            Views.MarketAccess MA = new Views.MarketAccess();
            return MA;
        }
    }
}
