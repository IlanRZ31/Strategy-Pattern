using StrategyPattern.Models;

namespace StrategyPattern.Service
{
    public class WorldWideShippingService : CheckOutService
    {

        public override decimal CalculateShipping(decimal orderTotal)
        {
            return orderTotal + 50;
        }
    }
}