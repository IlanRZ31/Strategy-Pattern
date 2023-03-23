using Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy_Pattern.Strategies
{
    public class WorldwideShippingStrategy : IShippingStrategy
    {
        public decimal CalculateFinalTotal(decimal orderTotal)
        {
            return orderTotal + 50;
        }
    }

}
