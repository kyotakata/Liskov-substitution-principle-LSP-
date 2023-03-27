using System;

namespace リスコフの置換原則.Objects
{
    public sealed class Gold : Member
    {
        public override int GetPoint(int price)
        {
            return Convert.ToInt32(price * 0.2f);
        }
    }
}
