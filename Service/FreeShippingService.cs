using StrategyPattern.Models;
using System;
using System.Web.UI;

namespace StrategyPattern.Service
{
    public class FreeShippingService : CheckOutService
    {
        public override decimal CalculateShipping(decimal orderTotal)
        {
            return orderTotal;
        }
    }
}