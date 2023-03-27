using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L061.Objects
{
    internal sealed class ProductSqlServer : ProductBase
    {
        protected override Product GetData()
        {
            throw new NotImplementedException();
        }

        protected override bool IsReady()
        {
            //SQLServerと接続チェック
            return true;
        }
    }
}
