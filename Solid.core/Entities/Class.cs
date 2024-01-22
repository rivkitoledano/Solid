namespace Solid.Core.Entities
{
    public class Class
    {
        public int ClassId { get; set; }
        public string Day { get; set; }
        public double Hour { get; set; }
        public int NumOfParticipants{ get; set; }
        public string Guide { get; set; }
        public string Name { get; set; }
        public int RomNum { get; set; }
        public int AgeAppropriate { get; set; }
        public List<Member> Members{ get; set; }
        public List<Equipment> Equipments { get; set; }//ציוד נצרך לקבוצה זאת
      
     
    }
}
