using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Testabilty
{
    class OrderProcessor
    {
        private IShippingCalculator shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            this.shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException();
            }
            order.shipment = new Shipment
            {
                Cost = shippingCalculator.CalculateShippng(order),
                ShippingDate = DateTime.Now.AddDays(1)
            };
        }
    }
}
