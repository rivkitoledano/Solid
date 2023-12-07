namespace Solid.Core.Entities
{
    public class Equipment
    {
        public static int Count { get; set; }
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int AmountItem { get; set; }
        public Equipment()
        {
            EquipmentId = Count++;

        }

    }
}
