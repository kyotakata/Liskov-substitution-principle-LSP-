using System;

namespace L130.Objects
{
    public sealed class X01
    {
        private MeasureA _measureA;

        public X01(int id,DateTime dataDate,float measureA,int temperature)
        {
            Id = id;
            DataDate = dataDate;
            _measureA = new MeasureA(measureA);
            Temperature = temperature;
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

        public int Temperature { get; }

        public float GetAve()
        {
            return MeasureA / Temperature;
        }
    }
}
