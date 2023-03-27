using System;

namespace L130.Objects
{
    public sealed class X02 //: X01
    {
        private MeasureA _measureA;

        public X02(int id, DateTime dataDate, float measureA,float measureB)
        {
            Id = id;
            DataDate = dataDate;
            _measureA = new MeasureA(measureA);
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
                return _measureA.GetValue(DataDate);
            }
        }

        public float MeasureB { get; }
    }
}
