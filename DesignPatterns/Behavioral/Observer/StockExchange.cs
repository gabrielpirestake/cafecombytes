using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    // Concrete Subject
    public class StockExchange : Investment
    {
        public StockExchange(string symbol, decimal price)
            : base(symbol, price)
        {
        }
    }
}
