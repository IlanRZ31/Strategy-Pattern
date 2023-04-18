namespace StrategyPattern.Service
{
    public class Context 
    {
        private IStrategy _strategy;
        private decimal _total;
        
        public Context()
        {
            
        }
        
        public void SetStrategyAndOrder(IStrategy strategy, decimal total)
        {
            _strategy = strategy;
            _total = total;
        }
        
        public decimal Execute()
        {
            return _strategy.CalculateShipping(_total);
        }
    }

    public interface IStrategy
    {
        decimal CalculateShipping(decimal total);
    }
}