using System.Data;

namespace L061.Objects
{
    public abstract class ProductBase
    {
        protected abstract Product GetData();
        protected abstract bool IsReady();

        public Product GetProduct()
        {
            if(IsReady())
            {
                return GetData();
            }

            return null;
        }
    }

    public static class ProductFactory
    {
        public static ProductBase Create()
        {
            return new ProductDummy();
        }
    }
}
