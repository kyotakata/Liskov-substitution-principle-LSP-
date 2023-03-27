using System;

namespace L090.Objects
{
    public sealed class X02 //: X01
    {
        private X01 _x01;

        public X02(X01 x01, float measureB)
        {
            _x01 = x01;
            MeasureB = measureB;
        }

        public int Id => _x01.Id;
        public DateTime DataDate => _x01.DataDate;
        public float MeasureA => _x01.MeasureA;

        public float MeasureB { get; }
    }
}
