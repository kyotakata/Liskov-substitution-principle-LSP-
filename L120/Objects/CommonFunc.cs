using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L120.Objects
{
    public static class CommonFunc
    {
        public static float GetMeasureA(float measureA, DateTime dataDate)
        {
            if (dataDate < DateTime.Now.AddDays(-30))
            {
                return 0;
            }

            return measureA;
        }
    }
}
