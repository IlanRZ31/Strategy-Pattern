using Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy_Pattern.Strategies
{
    public class ShippingContext : IShippingContext
    {
        private IShippingStrategy _strategy;

        public ShippingContext()
        { }

        public ShippingContext(IShippingStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IShippingStrategy strategy)
        {
            this._strategy = strategy;
        }

        public decimal ExecuteStrategy(decimal orderTotal)
        {
            return this._strategy.CalculateFinalTotal(orderTotal);
        }
    }
}
