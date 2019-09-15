using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Testabilty
{
    public interface IShippingCalculator
    {
        float CalculateShippng(Order order);
    }
    class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShippng(Order order)
        {
            //throw new NotImplementedException();
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            
            return 0;
        }
    }
}
