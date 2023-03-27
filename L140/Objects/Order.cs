using System;

namespace L140.Objects
{
    public sealed class Order
    {
        public Order(int orderId, DateTime orderDate, int productId, int price
            ,DateTime deleteDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            ProductId = productId;
            Price = price;
            DeleteDate = deleteDate;
        }

        public int OrderId { get; }
        public DateTime OrderDate { get; }
        public int ProductId { get; }
        public int Price { get; }
        public DateTime DeleteDate { get; }
        public string DeleteMode => "AAA";
    }
}
