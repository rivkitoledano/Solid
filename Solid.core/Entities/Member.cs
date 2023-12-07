namespace Solid.Core.Entities
{
    public class Member
    {
        public static int Count { get; set; }
        public int MemberId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Member()
        {
            MemberId=Count++;
        }

        
    }
}
