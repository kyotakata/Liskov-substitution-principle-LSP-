namespace L110.Objects
{
    public sealed class ProductViewModelDataSource
    {
        private ProductEntity _entity;
        public ProductViewModelDataSource(ProductEntity entity)
        {
            _entity = entity;
        }

        public string ProductId => _entity.ProductId.ToString().PadLeft(4, '0');
        public string ProductName => _entity.ProductName;

        public string XXXX { get; } = "XXXXDDD";
    }
}
