namespace Solid.Core.Entities
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int classId { get; set; }
        public Class clss { get; set; }
        
        
    }
}
