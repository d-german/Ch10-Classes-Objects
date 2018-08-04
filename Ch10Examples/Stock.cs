using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Examples
{
    public class Stock
    {
        private List<decimal> last4Prices = new List<decimal> { 22.5m, 21.0m, 19.5m, 18.0m };

        public decimal CurrentPrice { get; set; }
        public string Symbol { get; }

        public Stock(string symbol, decimal price = 0.0m)
        {
            Symbol = symbol;
            CurrentPrice = price;
        }

        public IEnumerable<decimal> Last4Prices
        {
            get
            {
                var copy = new decimal[last4Prices.Count];
                last4Prices.CopyTo(copy);
                return copy;
            }
            private set
            {
                Last4Prices = value;
            }
        }
    }
}
