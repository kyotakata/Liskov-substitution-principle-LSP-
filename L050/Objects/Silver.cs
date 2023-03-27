using System;

namespace L050.Objects
{
    public sealed class Silver : Member
    {
        public override int GetId()
        {
            return 777;
        }

        public override int GetPoint(int price)
        {
            return Convert.ToInt32(price * 0.1f);
        }
    }
}
