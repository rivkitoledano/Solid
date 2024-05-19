using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Class> ClassList { get; set; }
        public DbSet<Equipment> EquipmentList { get; set; }
        public DbSet<Member> MemberList { get; set; }
        public DbSet<Login> UserLogin { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Gym_Managment_db");
        }

    }   
}
