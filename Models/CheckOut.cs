using System.Collections.Generic;

namespace StrategyPattern.Models
{
    public class CheckOut
    {
        public decimal OrderTotal { get; set; }
        public int SelectedMethod { get; set; }
        public decimal FinalTotal { get; set; }
        public List<ShippingMethod> ShippingMethods { get; set; } 
    }
}