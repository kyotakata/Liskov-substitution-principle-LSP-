using System;

namespace L070.Objects
{
    public class X01
    {
        public int Id { get; }
        public DateTime DataDate { get; }
        public float MeasureA { get; }

        public int Temperature { get; }

        public float GetAve()
        {
            return MeasureA / Temperature;
        }
    }
}
