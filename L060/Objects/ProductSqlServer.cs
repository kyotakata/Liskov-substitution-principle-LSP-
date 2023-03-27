using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L060.Objects
{
    public sealed class ProductSqlServer : IProduct
    {
        public Product GetData()
        {
            throw new NotImplementedException();
        }

        public bool IsReady()
        {
            //SQLServerと接続チェック
            return true;
        }
    }
}
