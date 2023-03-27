namespace L110.Objects
{
    public sealed class ProductEntity
    {
        public ProductEntity(int productId,string productName,int price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }
        public int ProductId { get; }
        public string ProductName { get; }
        public int Price { get; }

        public string BarCode { get; }
    }
}
