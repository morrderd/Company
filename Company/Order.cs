using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
    }
}
