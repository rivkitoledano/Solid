using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Dto
{
    public class ClassDto
    {
        public int ClassId { get; set; }
        public string Day { get; set; }
        public double Hour { get; set; }
        public int NumOfParticipants { get; set; }
        public string Guide { get; set; }
        public string Name { get; set; }
        public int RomNum { get; set; }
        public int AgeAppropriate { get; set; }
        public List<Member> Members { get; set; }

    }
}
