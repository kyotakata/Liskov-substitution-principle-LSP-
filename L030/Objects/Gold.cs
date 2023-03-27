using System;

namespace L030.Objects
{
    public sealed class Gold : Member
    {
        public override int GetPoint(int price)
        {
            return Convert.ToInt32(price * 0.2f);
        }
    }
}
