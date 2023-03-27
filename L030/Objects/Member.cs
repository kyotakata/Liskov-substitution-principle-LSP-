namespace L030.Objects
{
    public class Member
    {
        public enum MemberKind
        {
            Silver,
            Gold,
        }

        public virtual int GetId()
        {
            return 999;
        }

        public virtual int GetPoint(int price)
        {
            return 0;
        }

        public static Member Create(MemberKind kind)
        {
            if(kind == MemberKind.Gold)
            {
                return new Gold();
            }

            return new Silver();
        }
    }
}
