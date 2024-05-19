using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repository
{
    public class ClassRepository : IClassRepository
    {
        private readonly DataContext _context;
        public ClassRepository(DataContext context)
        {
             _context=context;
        }
        public async Task<Class> AddClassAsync(Class clss)
        {
            _context.ClassList.Add(clss);
             await _context.SaveChangesAsync();
            return clss;
        }

        public async Task<Class> DeleteClassAsync(int id)
        {
            var tmp = _context.ClassList.ToList().Find(x => x.ClassId == id);
            _context.ClassList.Remove(tmp);
             await _context.SaveChangesAsync();
            return tmp;
        }

        public Class GetById(int id)
        {
            return _context.ClassList.Find(id);
        }

        public IEnumerable<Class> GetClasses()
        {
            return _context.ClassList.Include(ep => ep.Members).ToList();
        }

        public async Task<Class> UpdateClassAsync(int id, Class clss)
        {
            // Find the class by id
            var existingClass = await _context.ClassList.FindAsync(id);

            // Check if the class exists
            if (existingClass == null)
            {
                throw new KeyNotFoundException($"Class with id {id} not found.");
            }

            // Update the properties
            existingClass.Day = clss.Day;
            existingClass.Hour = clss.Hour;
            existingClass.NumOfParticipants = clss.NumOfParticipants;
            existingClass.Guide = clss.Guide;
            existingClass.Name = clss.Name;
            existingClass.RomNum = clss.RomNum;
            existingClass.AgeAppropriate = clss.AgeAppropriate;
            existingClass.Members = clss.Members;

            try
            {
                // Save changes to the database
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                // Handle any database update exceptions here
                throw new Exception("An error occurred while updating the class.", ex);
            }

            return existingClass;
        }

    }
}
