namespace L050.Objects
{
    public abstract class Member
    {
        public enum MemberKind
        {
            Silver,
            Gold,
            Platinum,
        }

        public virtual int GetId()
        {
            return 999;
        }

        public abstract int GetPoint(int price);

        public virtual int GetDoublePoint(int price)
        {
            return 0;
        }



        public static Member Create(MemberKind kind)
        {
            if(kind == MemberKind.Gold)
            {
                return new Gold();
            }

            if (kind == MemberKind.Platinum)
            {
                return new Platinum();
            }

            return new Silver();
        }
    }
}
