using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L100.Objects
{
    public sealed class OrderEvent
    {
        private Order _order;
        public OrderEvent(Order order)
        {
            _order = order;

            EventId = Guid.NewGuid().ToString();
        }

        public string EventId { get; }

        public int OrderId => _order.OrderId;
    }
}
