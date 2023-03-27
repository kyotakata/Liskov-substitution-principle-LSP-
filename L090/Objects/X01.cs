using System;

namespace L090.Objects
{
    public sealed class X01
    {
        private float _measureA;

        public X01(int id,DateTime dataDate,float measureA,int temperature)
        {
            Id = id;
            DataDate = dataDate;
            _measureA = measureA;
            Temperature = temperature;
        }

        public int Id { get; }
        public DateTime DataDate { get; }
        public float MeasureA
        {
            get
            {
                if (DataDate < DateTime.Now.AddDays(-30))
                {
                    return 0;
                }

                return _measureA;
            }
        }

        public int Temperature { get; }

        public float GetAve()
        {
            return MeasureA / Temperature;
        }
    }
}
