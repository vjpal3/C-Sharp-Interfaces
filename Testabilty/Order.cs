using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Testabilty
{
    public class Order
    {
        public bool IsShipped { get; set; }
        public Shipment Shipment{ get; set; }
        public DateTime DatePlaced { get; set; }

        public float TotalPrice { get; set; }
    }
}
