namespace StrategyPattern.Service
{
    public class Context 
    {
        private IStrategy _strategy;
        
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }
        
        public void Execute()
        {
            _strategy.CalculateShipping();
        }
    }

    public interface IStrategy
    {
        void CalculateShipping();
    }
}