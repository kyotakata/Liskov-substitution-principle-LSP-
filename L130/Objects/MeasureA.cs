using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L130.Objects
{
    public class MeasureA
    {
        private readonly float _value;
        public MeasureA(float value)
        {
            _value = value;
        }

        public float GetValue(DateTime dataDate)
        {
            if (dataDate < DateTime.Now.AddDays(-30))
            {
                return 0;
            }

            return _value;
        }
    }
}
