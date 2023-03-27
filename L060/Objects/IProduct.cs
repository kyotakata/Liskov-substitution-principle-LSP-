using System.Data;

namespace L060.Objects
{
    public interface IProduct
    {
        Product GetData();
        bool IsReady();
    }

    public static class ProductFactory
    {
        public static IProduct Create()
        {
            return new ProductDummy();
        }
    }
}
