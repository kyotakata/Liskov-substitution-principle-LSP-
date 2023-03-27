namespace L020.Objects
{
    public enum MemberKind
    {
        Silver,
        Gold,
    }

    public interface IMember
    {
        int GetPoint(int price);

       
    }

    public static class MemberFactory
    {
        public static IMember Create(MemberKind kind)
        {
            if (kind == MemberKind.Gold)
            {
                return new Gold();
            }

            return new Silver();
        }
    }
}
