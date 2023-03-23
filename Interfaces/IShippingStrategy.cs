using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy_Pattern.Interfaces
{
    public interface IShippingStrategy
    {
        decimal CalculateFinalTotal(decimal orderTotal);
    }
}
