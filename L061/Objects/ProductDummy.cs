namespace L061.Objects
{
    internal sealed class ProductDummy : ProductBase
    {
        protected override Product GetData()
        {
            return new Product(1,"AAA",100);
        }

        protected override bool IsReady()
        {
            return true;
        }
    }
}
