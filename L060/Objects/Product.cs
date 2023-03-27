namespace L060.Objects
{
    public sealed class Product
    {
        public Product(int productId,string productName,int price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }

        public int ProductId { get; }
        public string ProductName { get; }
        public int Price { get; }
    }
}
