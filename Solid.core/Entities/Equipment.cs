namespace Solid.Core.Entities
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int AmountItem { get; set; }
        public List<Class> Classes{ get; set; }//קבוצות שמשתמשות ברכיב ציוד זה
     

    }
}
