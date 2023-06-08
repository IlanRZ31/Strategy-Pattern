namespace StrategyPattern.Service
{
    public abstract class CheckOutService : IStrategy
    {
        private decimal _orderTotal;
        
        public void CalculateShipping()
        {
            CalculateShipping(_orderTotal);
        }
        
        public abstract decimal CalculateShipping(decimal orderTotal);
    }
}