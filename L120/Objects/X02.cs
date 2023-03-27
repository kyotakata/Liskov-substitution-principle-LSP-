using System;

namespace L120.Objects
{
    public sealed class X02 //: X01
    {
        private float _measureA;

        public X02(int id, DateTime dataDate, float measureA,float measureB)
        {
            Id = id;
            DataDate = dataDate;
            _measureA = measureA;
            MeasureB = measureB;
        }

        public int Id { get; }
        public DateTime DataDate { get; }
        public float MeasureA
        {
            get
            {
                //if (DataDate < DateTime.Now.AddDays(-30))
                //{
                //    return 0;
                //}

                //return _measureA;
                return CommonFunc.GetMeasureA(_measureA, DataDate);
            }
        }

        public float MeasureB { get; }
    }
}
