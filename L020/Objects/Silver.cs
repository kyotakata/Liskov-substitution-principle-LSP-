using System;

namespace L020.Objects
{
    public sealed class Silver : IMember
    {
        public int GetPoint(int price)
        {
            return Convert.ToInt32(price * 0.1f);
        }
    }
}