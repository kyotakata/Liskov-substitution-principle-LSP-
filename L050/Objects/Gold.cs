using System;

namespace L050.Objects
{
    public sealed class Gold : Member
    {
        public override int GetPoint(int price)
        {
            return Convert.ToInt32(price * 0.2f);
        }

        public override int GetDoublePoint(int price)
        {
            return Convert.ToInt32(price * 0.4f);
        }
    }
}
