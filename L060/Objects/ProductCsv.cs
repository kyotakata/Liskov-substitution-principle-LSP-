using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L060.Objects
{
    public sealed class ProductCsv : IProduct
    {
        public Product GetData()
        {
            throw new NotImplementedException();
        }

        public bool IsReady()
        {
            return true;
        }
    }
}
