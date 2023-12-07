using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataContext
    {
        public List<Class> ClassList { get; set; }
        public List<Equipment> EquipmentList { get; set; }
        public List<Member> MemberList { get; set; }
        public DataContext()
        {


            ClassList = new List<Class>()
            {
            new Class(){ClassId=Class.Count, Day = "Monday",Hour = 9.5,NumOfParticipants = 10,Guide = "Avi", Name = "TennegerGroup",AgeAppropriate=15},
            new Class()  {ClassId=Class.Count,Day = "Tuesday",Hour = 14.25, NumOfParticipants = 8,Guide = "Yahir",  Name = "YungerGroup",AgeAppropriate=30 },
            new Class(){ClassId = Class.Count,  Day = "Wednesday", Hour = 11.75, NumOfParticipants = 12,Guide = "Gali", Name = "OldGroup",AgeAppropriate=70 }
            };

            EquipmentList = new List<Equipment>()
            {
               new Equipment() {EquipmentId=Equipment.Count, Name = "Item 1", Category = "Category 1", AmountItem = 5 },
               new Equipment() {EquipmentId=Equipment.Count, Name = "Item 2", Category = "Category 2", AmountItem = 10 },
               new Equipment() {EquipmentId=Equipment.Count, Name = "Item 3", Category = "Category 1", AmountItem = 3 },
               new Equipment() {EquipmentId=Equipment.Count, Name = "Item 4", Category = "Category 3", AmountItem = 8 },
               new Equipment() { EquipmentId=Equipment.Count,Name = "Item 5", Category = "Category 2", AmountItem = 6 }
            };
            MemberList = new List<Member>()
            {
              new Member() {MemberId=Member.Count, Name = "eli", Age = 25 },
              new Member() { MemberId=Member.Count,Name = " Daniel", Age = 30 },
              new Member() {MemberId=Member.Count, Name = "Michael", Age = 45 },
               new Member() {MemberId=Member.Count, Name = "Sarah", Age = 35 },
             new Member() {MemberId=Member.Count,Name = "David", Age = 28 }
            };
    }   }
}
