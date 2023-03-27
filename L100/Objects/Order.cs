using System;

namespace L100.Objects
{
    public sealed class Order
    {
        public int OrderId { get; }
        public DateTime OrderDate { get; }
        public int ProductId { get; }
        public int Price { get; }
    }
}
